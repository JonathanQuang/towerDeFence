﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derp : MonoBehaviour
{

    public GameObject Cube; //The Cube
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector3(0f, 5f, 0f);
        }
        
 

        //if you want to make it so it is whatever the script is attatched to, instead of "Cube.transform.position"; Do gameObject.transform.position
        //Also instead of 1f, 0f, 0f
        //You can customize it to whatever you want (x,y,z)
        //If you do decimals do "f" don't just do "5.4" do "5.4f"
        //This is in the update function, it will happen per frame. Feel free to have it in any other function :)


    }
}