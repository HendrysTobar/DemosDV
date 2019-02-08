using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour 
{
	#region Enums
	
	
    #endregion
	
    #region Atributos y Propiedades
	
	
    #endregion
	
    #region Eventos    
	
	
    #endregion
	
    #region Mensajes Unity
	
	void Start ()
    {
        StartCoroutine(MoverVirus());
		
	}

    Quaternion rotacionObjetivo;
    // Update is called once per frame
    void Update()
    {
        /*
        //Se mueve un poquito hacia adelante
        transform.Translate(Time.deltaTime * transform.forward);
        //generamos un angulo al azar entre -10 y 10
        float angle = Random.Range(-10, 10);
        //Rota hacia el angulo calculado
        transform.Rotate(Vector3.up, angle, Space.World);
        */
        
		
	}
	#endregion
	
    #region Métodos
	
	
    #endregion
    #region CoRutinas
	public IEnumerator MoverVirus()
    {
        while(transform.position.z < 18)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
            yield return new WaitForSeconds(0.5f);
        }
        while(transform.position.z > -12)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
            yield return null;
        }
        Destroy(this.gameObject);

    }
	
	#endregion
}
