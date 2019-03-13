using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


	public class EstadoMuerte : EstadoMEF
	{
	
		
	
		public override void Salir()
		{
			GetComponent<Renderer>().enabled = true;
		}

		public override void Start()
		{
			GetComponent<Renderer>().enabled = false;
			base.Start();
		}

		public override void Update()
		{
			Vector3 dif = Vector3.zero - transform.position;
			dif.Normalize();
		
			transform.Translate(blinky.velocidad * 3.0f * dif, Space.World);
		
			VerificarCambio();
		
		}

		public override Type VerificarTransiciones ()
		{
			if(Vector3.Distance(transform.position, Vector3.zero ) <= 0.1f)
			{
				return typeof(EstadoSaliendo);
				
			}
			return this.GetType();
		}
	}

