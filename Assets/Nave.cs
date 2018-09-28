using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Mover un poquito hacia la derecha
        //Right (1,0,0);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(5 * Time.deltaTime * Vector3.right);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(-5 * Time.deltaTime * Vector3.right);

    }
}
