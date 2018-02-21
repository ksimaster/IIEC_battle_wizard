using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {

    public GameObject obj;
    public float range = 5f;
    public float moveSpeed = 3f, turnSpeed = 40f;

		
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);


    }
}
