using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public enum Direction
    {
        Right,
        Left
    };

    public Bullet bulletPrefab;
    public float moveVector = 0.2f;

    private List<GameObject> bullts = new List<GameObject>();

    public void Move(Direction dir)
    {
        var pos = transform.localPosition;
        if (dir == Direction.Right)
        {
            pos.x += moveVector;
        }
        else
        {
            pos.x -= moveVector;
        }
        transform.localPosition = new Vector3(pos.x, pos.y, pos.z);
    }

    public void Fire(float speed)
    {
        bullts.RemoveAll(x => x == null);

        var bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.SetSpeed(speed);

        bullts.Add(bullet.gameObject);
    }

    void OnTriggerEnter(Collider collision)
    {
        if(bullts.Contains(collision.gameObject))
        {
            return;
        }

        bullts.Remove(collision.gameObject);
        Destroy(collision.gameObject);
    }
}
