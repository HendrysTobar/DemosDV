using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


	public class EstadoVagando : EstadoMEF
	{
	
		Vector3 direccionMovimiento;
		
	
	
		public override void Salir()
		{
			
		}

		public override void Start()
		{
			direccionMovimiento = transform.forward;
			base.Start();
		}

		public override void Update()
		{
			
		
		
			float cambioX = Mathf.Lerp(-.25f, .25f, UnityEngine.Random.value);
			float cambioZ = Mathf.Lerp(-.25f, .25f, UnityEngine.Random.value);
		
			direccionMovimiento = new Vector3(direccionMovimiento.x + cambioX,0.0f, direccionMovimiento.z + cambioZ );
				
			
			Quaternion nuevaRotacion = Quaternion.FromToRotation(Vector3.forward, direccionMovimiento);
			transform.rotation = nuevaRotacion;
		
			transform.Translate(blinky.velocidad * transform.forward * Time.deltaTime);
			
			VerificarCambio();
			
		
		}
	
		void OnTriggerEnter(Collider hit)
		{
			if(hit.tag == "Muro")
			{
				direccionMovimiento = -direccionMovimiento;
			}
		}

		
		public override Type VerificarTransiciones ()
		{
			if(!PacMan.Singleton.estaMuerto)
			{
				return typeof(EstadoPersiguiendo);
			}
		
		
			return this.GetType();
		}
		
	}

