using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Player player;
    public Player enemy;

    MainSystem system;

    void Start() {
        player.OnDead += PlayerDead;

        system = MainSystem.Instance;
        if (system == null)
        {
            return;
        }
        system.Executor.OnReceivePlayerPosition += EnemyMove;
        system.Executor.OnReceiveBulletFire += EnemyBulletFire;
        system.Executor.OnReceivePlayerDead += GameOver;
	}

    void OnDestroy()
    {
        player.OnDead -= PlayerDead;

        if (system == null)
        {
            return;
        }
        system.Executor.OnReceivePlayerPosition -= EnemyMove;
        system.Executor.OnReceiveBulletFire -= EnemyBulletFire;
        system.Executor.OnReceivePlayerDead -= GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Fire(0.2f);
            if(system)
            {
                system.Session.SendPlayerBulletFire();
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.Move(Player.Direction.Right);
            if (system)
            {
                system.Session.SendPlayerPosition(Player.Direction.Right);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.Move(Player.Direction.Left);
            if (system)
            {
                system.Session.SendPlayerPosition(Player.Direction.Left);
            }
        }
	}

    void PlayerDead()
    {
        Debug.Log("Game Over");
        if (system)
        {
            system.Session.SendPlayerDead();
        }
    }

    void GameOver(Network.PlayerDead msg)
    {
        Debug.Log("Game Over");
    }

    void EnemyMove(Network.PlayerPosition msg)
    {
        enemy.Move(msg.direction);
    }

    void EnemyBulletFire(Network.BulletFire msg)
    {
        enemy.Fire(-0.2f);
    }
}
