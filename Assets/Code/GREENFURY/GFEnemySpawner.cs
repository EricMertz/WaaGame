using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GFEnemySpawner : MonoBehaviour {

    public GameObject prefab;
    public float SpawnRate;

    private float SpawnTimer;
    // Use this for initialization
    void Start () {
        SpawnTimer = Time.time + SpawnRate;
        Vector3 center = transform.position;
        Vector3 pos = RandomCircle(center, 5.0f);
        Instantiate(prefab, pos, Quaternion.identity);
        

    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

    // Update is called once per frame
    void Update () {
        if (SpawnTimer < Time.time)
        {
            SpawnTimer = Time.time + SpawnRate;
            Vector3 center = transform.position;
            Vector3 pos = RandomCircle(center, 5.0f);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}
