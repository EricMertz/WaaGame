using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour {
    public GameObject cold_wall; //prefab for cold wall
    public GameObject hot_wall; // prefab for hot wall

    private GameObject curr;

	// Use this for initialization
	void Start () {
		curr = Instantiate(cold_wall, transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (curr.tag == "FireWall")
            {
                Destroy(curr);
                curr = Instantiate(cold_wall, transform.position, Quaternion.identity);
            }
            else if (curr.tag == "IceWall")
            {
                Destroy(curr);
                curr = Instantiate(hot_wall, transform.position, Quaternion.identity);
            }
        }
                
	}
}
