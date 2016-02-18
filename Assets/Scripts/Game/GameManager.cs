using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Player player;
    public Player enemy;

    MainSystem system;

    void Start() {
        system = MainSystem.Instance;
        if (system == null)
        {
            return;
        }
        system.Executor.OnReceivePlayerPosition += EnemyMove;
	}

    void OnDestroy()
    {
        if (system == null)
        {
            return;
        }
        system.Executor.OnReceivePlayerPosition -= EnemyMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Fire(0.2f);
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

    void EnemyMove(Network.PlayerPosition msg)
    {
        enemy.Move(msg.direction);
    }
}
