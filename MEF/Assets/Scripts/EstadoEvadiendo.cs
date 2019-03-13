using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


	public class EstadoEvadiendo : EstadoMEF
	{
		
		PacMan pacMan = PacMan.Singleton;
		bool seMurio;
	
		public override void Salir()
		{
			this.GetComponent<Renderer>().material.color = Color.red;
		}

		public override void Start()
		{
			this.GetComponent<Renderer>().material.color = Color.blue;
			base.Start();
		}

		public override void Update()
		{
			Vector3 to = pacMan.objetoEscena.transform.position;
			Vector3 dif = to - this.transform.position;
			dif.Normalize();
		
			dif *= -1;
		
			transform.Translate(blinky.velocidad * dif * Time.deltaTime, Space.World);
			transform.rotation = Quaternion.FromToRotation(Vector3.forward, new Vector3(dif.x, 0,dif.z))	;
		
			VerificarCambio();
		
	
		}	
	
		void OnTriggerEnter(Collider hit)
		{
			if(hit.transform.tag == "Player")
			{		
				seMurio = true;				
			}
		}
	
		
		public override Type VerificarTransiciones ()
		{
			if(!pacMan.estaFurioso)
			{
				return typeof (EstadoPersiguiendo);
			}
			
			if(seMurio)
			{
				return typeof(EstadoMuerte);
				
			}
		
		
			return this.GetType();
		}
		
	}

