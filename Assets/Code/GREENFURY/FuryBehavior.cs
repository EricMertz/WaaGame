using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuryBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.RotateAround(Vector3.zero, Vector3.back, 180 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.back, -180 * Time.deltaTime);
        }

    }
}
