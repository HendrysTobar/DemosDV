using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public List<GameObject> cubos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Explotar()
    {

        foreach (GameObject c in cubos)
        {
            Rigidbody rb = c.GetComponent<Rigidbody>();
            rb.AddExplosionForce(1000.0f, this.transform.position, 300.0f);
        }
    }
}
