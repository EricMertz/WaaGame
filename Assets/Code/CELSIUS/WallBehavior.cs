using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour {
    private GameController gameController;
    private string this_tag;

    // Use this for initialization
    void Start () {
        this_tag = tag;
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
		
	}

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("test");
        if (this_tag == "FireWall")
        {
            if (coll.gameObject.tag == "HotEnemy")
            {

                gameController.AddScore(1);
                Debug.Log("calledAddScore");
                Destroy(coll.gameObject);
                
            }
        }
        if (this_tag == "IceWall")
        {
            if (coll.gameObject.tag == "ColdEnemy")
            {
                gameController.AddScore(1);
                Destroy(this.gameObject);
                
            }
        }
    }
}
