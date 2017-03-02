using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    public GameObject obj; //prefab for freeze enemies

    public float SpawnRate;

    private float SpawnTimer;

    // Use this for initialization
    void Start () {
        GameObject temp = Instantiate(obj, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody2D>().AddForce(temp.transform.right * Random.Range(-50, 50));
        SpawnTimer = Time.time + SpawnRate;
    }
	
	// Update is called once per frame
	void Update () {
        if (SpawnTimer < Time.time)
        {
            GameObject temp = Instantiate(obj, transform.position, Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce(temp.transform.right * Random.Range(-50, 50));
            SpawnTimer = Time.time + SpawnRate;
        }
    }
}
