using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
            Debug.Log("down");
    }
    void OnMouseDown()
    {
        Debug.Log("clicked");
        rb.velocity = new Vector3(rb.velocity.x, Mathf.Abs(rb.velocity.y));
    }

}
