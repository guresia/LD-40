using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speedIncrement = 0.00001f;
    private float horizontalSpeed = 0;
    private float deadZone = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void FixedUpdate ()
    {
        FixedMove();
    }

    private void FixedMove()
    {
        if (horizontalSpeed != 0)
        {
            transform.position = new Vector3(transform.position.x + horizontalSpeed, transform.position.y, transform.position.z);
        }
    }

    private void Move()
    {
        if (Input.GetAxis("Horizontal") > deadZone)
        {
            horizontalSpeed = speedIncrement;
        }
        else if (Input.GetAxis("Horizontal") < - deadZone)
        {
            horizontalSpeed = -speedIncrement;
        }
        else
        {
            horizontalSpeed = 0;
        }

        Debug.Log(Input.GetAxis("Horizontal"));
    }
}
