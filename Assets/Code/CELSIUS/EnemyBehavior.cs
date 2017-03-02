using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
    public float speed;
    public Rigidbody2D rb;
    private string this_tag;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        this_tag = tag;
        rb.AddForce(-transform.right*speed);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(tag == "HotEnemy")
        {
            if(coll.gameObject.tag == "FireWall")
            {
                Destroy(this.gameObject);
            }
        }
        if(tag == "ColdEnemy")
        {
            if (coll.gameObject.tag == "IceWall")
            {
                Destroy(this.gameObject);
            }
        }

    }
}
