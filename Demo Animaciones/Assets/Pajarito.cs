﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajarito : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Disparar()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(5.0f * new Vector3(0,1,-1),ForceMode.VelocityChange);
    }
}
