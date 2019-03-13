using System;
using System.Collections.Generic;
using UnityEngine;


public class EstadoSaliendo: EstadoMEF
{
	
	bool salioDeLaCaja = false;
	//Este es un método sobrecargado
	public override void Salir ()
	{
		//TODO: Programar el metodo salir
	}
	
	public override void Start ()
	{
		transform.rotation = Quaternion.identity;
		
		
		base.Start();
	}

	public override void Update ()
	{
		transform.Translate(Vector3.forward * blinky.velocidad * Time.deltaTime, Space.World);
		
		VerificarCambio();
	}

	public override Type VerificarTransiciones ()
	{
		if(salioDeLaCaja)
			return typeof(EstadoPersiguiendo);
		else
			return this.GetType();
	}
	
	
	void OnTriggerExit()
	{
		salioDeLaCaja = true;
	}
	
	
}

	