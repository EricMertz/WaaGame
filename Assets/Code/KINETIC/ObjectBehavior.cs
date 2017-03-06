using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {

    public Rigidbody2D rb;
    private GameController gameController;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButton(0))
            //Debug.Log("down");

    }
    void OnMouseDown()
    {
        //Debug.Log("clicked");
        if(rb.velocity.y <= 0)
            gameController.AddScore(1); //CHANGE THIS
        rb.velocity = new Vector3(rb.velocity.x, Mathf.Abs(rb.velocity.y));
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("colliding");
        if (coll.gameObject.tag == "DeathWall")
        {
            if (gameController.get_count() <= 1)
            {
                gameController.GameOver();
            }
            else
            {
                gameController.TakeLife();
                Destroy(this.gameObject);
            }
        }

    }

}
