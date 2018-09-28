using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    //Atributos y propiedades
    public float velocidad;
    public Vector3 direccion;
    private Vector3 posOriginal;

    private bool yaDisparo = false;

	// Use this for initialization
	void Start ()
    {
        posOriginal = transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
    {  //Mientras que no llegue al final  
        int cont = 0;
        bool yasalio = transform.position.z > 10;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            yaDisparo = true;

          
          
           
            
        }

        if (!yasalio && yaDisparo)
        {
            //Muevase
            #region seguridad
            cont++;

            #endregion
            transform.position = transform.position + (velocidad * direccion);
            yasalio = transform.position.z > 10;
        }

        if(yasalio)
        {
            yasalio = false;
            transform.position = posOriginal;
            yaDisparo = false;

        }
    }
}
