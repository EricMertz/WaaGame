using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GFEnemyBehavior : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, Time.deltaTime*speed);
        //Debug.Log(transform.position);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("colliding");
        if (coll.gameObject.tag == "GreenFury")
            Destroy(this.gameObject);


    }
}
