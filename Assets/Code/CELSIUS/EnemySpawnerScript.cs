using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject cold; //prefab for freeze enemies
    public GameObject hot; //prefab for fire enemies
    public float speed;
    
    public float SpawnRate;

    private float SpawnTimer;

    private GameController gameController;

    // Use this for initialization
    void Start () {
		SpawnTimer = Time.time + SpawnRate;

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
        if (!gameController.gamestate())
        {
            if (SpawnTimer < Time.time)
            {
                float temp = Random.Range(0f, 1f);
                if (temp < 0.5f)
                {
                    GameObject yolo = Instantiate(cold, transform.position, Quaternion.identity);
                    yolo.GetComponent<Rigidbody2D>().AddForce(-yolo.transform.right * speed);
                    SpawnTimer = Time.time + Random.Range(.2f, SpawnRate);
                    if (SpawnRate > 3f)
                    {
                        SpawnRate *= .99f;
                    }
                }
                else
                {
                    GameObject yolo = Instantiate(hot, transform.position, Quaternion.identity);
                    yolo.GetComponent<Rigidbody2D>().AddForce(-yolo.transform.right * speed);
                    SpawnTimer = Time.time + Random.Range(.2f, SpawnRate);
                    if (SpawnRate > 3f)
                    {
                        SpawnRate *= .99f;
                    }
                }
            }
        }
        
    }
}
