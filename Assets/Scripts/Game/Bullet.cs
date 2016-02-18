using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 0;

    public void SetSpeed(float sp)
    {
        speed = sp;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position += Vector3.up * speed;

        if(Mathf.Abs(transform.position.y) > 10)
        {
            Destroy(gameObject);
        }
	}
}
