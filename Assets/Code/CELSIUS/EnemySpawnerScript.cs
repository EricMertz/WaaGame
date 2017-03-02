using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject cold; //prefab for freeze enemies
    public GameObject hot; //prefab for fire enemies
    
    public float SpawnRate;

    private float SpawnTimer;

    // Use this for initialization
    void Start () {
		SpawnTimer = Time.time + SpawnRate;
    }
	
	// Update is called once per frame
	void Update () {
        if (SpawnTimer < Time.time)
        {
            float temp = Random.Range(0f, 1f);
            if (temp < 0.5f)
            {
                Instantiate(cold, transform.position, Quaternion.identity);
                SpawnTimer = Time.time + Random.Range(.2f,SpawnRate);
                if (SpawnRate > 3f)
                {
                    SpawnRate *= .99f;
                }
            }
            else
            {
                Instantiate(hot, transform.position, Quaternion.identity);
                SpawnTimer = Time.time + Random.Range(.2f, SpawnRate);
                if (SpawnRate > 3f)
                {
                    SpawnRate *= .99f;
                }
            }
        }
        
    }
}
