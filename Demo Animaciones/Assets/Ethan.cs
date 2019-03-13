using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Consultamos el objeto con el que se colisionó
        GameObject otro = collision.gameObject;
        //Es enemigo si el tag del otro es "Enemigo"
        bool esEnemigo = otro.tag == "Enemigo";
        //si es enemigo
        if (esEnemigo)
        {
            //Destruya el otro
            Destroy(otro);
        }
    }







}
