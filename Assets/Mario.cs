using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour {

	// Use this for initialization
    //Se ejcuta una sola vez
	void Start ()
    {
        this.transform.position = Vector3.zero;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Mover un poquito hacia la derecha
        //Right (1,0,0);
        if(Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(5 * Time.deltaTime * Vector3.right);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(-5 * Time.deltaTime * Vector3.right);

        //time.detltatiem = 1/60




    }
}
