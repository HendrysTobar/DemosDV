using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovimientoGiro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Si se presiona Left Arrow
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //Apuntar al Oeste
            //this.transform.rotation = Quaternion.AngleAxis(180f, Vector3.up);
            //Esto es equivalente
            this.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Apuntar al Oeste
            //this.transform.rotation = Quaternion.AngleAxis(0f, Vector3.up);
            //Esto es equivalente
            this.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.right);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Apuntar al Oeste
            //this.transform.rotation = Quaternion.AngleAxis(90f, Vector3.forward);
            //Esto es equivalente
            this.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.up);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Apuntar al Oeste
            //this.transform.rotation = Quaternion.AngleAxis(-90f, Vector3.forward);
            //Esto es equivalente
            this.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.down);
           
        }

        transform.Translate(Vector3.right * Time.deltaTime);		
	}
}
