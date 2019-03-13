using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


	public class EstadoPersiguiendo: EstadoMEF
	{
	
	
		PacMan pacMan = PacMan.Singleton;
		bool matoAPacMan = false;
		
	
	
	
		public override void Salir()
		{
			
		}

		public override void Start()
		{
			pacMan = PacMan.Singleton;
			base.Start();
		}

		public override void Update()
		{
			Vector3 to = pacMan.objetoEscena.transform.position;
			Vector3 dif = to - this.transform.position;
			dif.Normalize();
		
			transform.Translate(blinky.velocidad * dif * Time.deltaTime, Space.World);
			transform.rotation = Quaternion.FromToRotation(Vector3.forward, new Vector3(dif.x, 0,dif.z));
		
			VerificarCambio();
			
		
		
		
		
		}
		
		void OnTriggerEnter(Collider hit)
		{
			if(hit.transform.tag == "Player")
			{		
				matoAPacMan = true;
				pacMan.estaMuerto = true;
			}
		}
	
	
	

		public override Type VerificarTransiciones ()
		{
			if(matoAPacMan)			{
			
				return typeof(EstadoVagando);
			}
		
			if(pacMan.estaFurioso)
			{
				return typeof(EstadoEvadiendo);				
			}
		
		
			return this.GetType();
		
			
		}
		   
		   
		   
	}

