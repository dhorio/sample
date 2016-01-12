using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Player player;
    public Player enemy;

	// Use this for initialization
	void Start () {

        MainSystem.Instance.Executor.OnReceivePlayerPosition += EnemyMove;
	
	}

    void OnDestroy()
    {
        MainSystem.Instance.Executor.OnReceivePlayerPosition -= EnemyMove;
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            player.Move(Player.Direction.Right);
            MainSystem.Instance.Session.SendPlayerPosition(Player.Direction.Right);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            player.Move(Player.Direction.Left);
            MainSystem.Instance.Session.SendPlayerPosition(Player.Direction.Left);
        }
	
	}

    void EnemyMove(Network.PlayerPosition msg)
    {
        enemy.Move(msg.direction);
    }
}
