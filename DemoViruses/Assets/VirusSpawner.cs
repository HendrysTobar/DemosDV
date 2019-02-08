using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour 
{
    #region Enums


    #endregion

    #region Atributos y Propiedades
    //Define el objeto original a instanciar
    public GameObject virusPrefab;

    #endregion

    #region Eventos    


    #endregion

    #region Mi Region
    

    #endregion

    #region Mensajes Unity

    void Start ()
    {
        StartCoroutine(CorutinaEngendrarViruses());		
	}

    // Update is called once per frame
    int t = 0;
	void Update ()
    {
        		
	}
    #endregion

    #region Métodos
    public void SpawnVirus()
    {
        //Instancia un nuevo virus en la posición de este objeto
        Instantiate(virusPrefab, this.transform.position,virusPrefab.transform.rotation);
    }

    public IEnumerator CorutinaEngendrarViruses()
    {
        while (true)
        {
            //RENDIR
            yield return new WaitForSeconds(3f);
            SpawnVirus();
        }
    }
	
    #endregion




    #region CoRutinas
	
	
	#endregion
}
