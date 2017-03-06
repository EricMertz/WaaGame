using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GFEnemyBehavior : MonoBehaviour {
    public float speed;
    private GameController gameController;
    // Use this for initialization
    void Start () {
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
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, Time.deltaTime*speed);
        //Debug.Log(transform.position);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("colliding");
        if (coll.gameObject.tag == "GreenFury")
        {
            gameController.AddScore(1);
            Destroy(this.gameObject);
        }

        if(coll.gameObject.tag == "Tree")
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
