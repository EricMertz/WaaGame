using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    public GameObject obj; //prefab for freeze enemies

    public float SpawnRate;

    private int neg;
    private float SpawnTimer;

    // Use this for initialization
    void Start () {
        neg = -1;
        GameObject temp = Instantiate(obj, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody2D>().AddForce(temp.transform.right * neg*Random.Range(100,200));
        neg *= -1;
        SpawnTimer = Time.time + SpawnRate;
    }
	
	// Update is called once per frame
	void Update () {
        if (SpawnTimer < Time.time)
        {
            GameObject temp = Instantiate(obj, transform.position, Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce(temp.transform.right * neg * Random.Range(100, 200));
            neg *= -1;
            SpawnTimer = Time.time + SpawnRate;
        }
    }
}
