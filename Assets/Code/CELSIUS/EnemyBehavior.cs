using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    //public float speed;
    public Rigidbody2D rb;
    private string this_tag;
    private GameController gameController;


    // Use this for initialization
    void Start () {
        //rb = GetComponent<Rigidbody2D>();
        this_tag = tag;
        //rb.AddForce(-transform.right*speed);
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
	void FixedUpdate () {
        /*if (gameController.gamestate())
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            
        }*/
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(tag == "HotEnemy")
        {
            if(coll.gameObject.tag == "FireWall")
            {
                gameController.AddScore(1);
                Destroy(this.gameObject);
            }
            else if (coll.gameObject.tag == "IceWall")
            {
                if(gameController.get_count() <= 1)
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
        else if(tag == "ColdEnemy")
        {
            if (coll.gameObject.tag == "IceWall")
            {
                gameController.AddScore(1);
                Destroy(this.gameObject);
            }
            if (coll.gameObject.tag == "FireWall")
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
}
