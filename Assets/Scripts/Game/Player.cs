using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Direction
    {
        Right,
        Left
    };

    public float moveVector = 0.2f;

	// Use this for initialization
	void Start () {
	
	}

    public void Move(Direction dir)
    {
        var pos = transform.localPosition;
        if(dir == Direction.Right)
        {
            pos.x += moveVector;
        }
        else
        {
            pos.x -= moveVector;
        }
        transform.localPosition = new Vector3(pos.x, pos.y, pos.z);
    }
}
