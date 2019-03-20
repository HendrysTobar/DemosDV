using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EthanNavigable : MonoBehaviour 
{
    #region Enums


    #endregion

    #region Atributos y Propiedades


    #endregion

    #region Eventos    


    #endregion

    #region Mensajes Unity
    public Transform goal;
    NavMeshAgent agent;
    Animator anim;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.destination = goal.position;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Si la velocidad del agente navegable es mayor que 0.1f
        if (agent.velocity.sqrMagnitude >= 0.1f)
        {
            //entonces, pone el parametro de la animación Forward a 0.5f
            anim.SetFloat("Forward", 0.5f);
        }
        else
        {
            anim.SetFloat("Forward", 0.0f);
        }

		
	}
	#endregion
	
    #region Métodos
	
	
    #endregion
    #region CoRutinas
	
	
	#endregion
}
