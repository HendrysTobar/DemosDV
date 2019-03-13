using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MEF
{
	public class MEF : MonoBehaviour
	{
		//Campos
		EstadoMEF estadoActual;
		
	
		
		
		//Propiedades
		
		//Constructor
		public MEF(EstadoMEF estadoInicial)
		{
			//verificamos si el estadoINicial que nos dan es nulo
			if(estadoInicial == null)
				//si lo es lanzamos una excepcion
				throw new ArgumentNullException("El estado no puede ser null");
			
			//Se asigna al estadoActual, el estado Inicial que se da en el parámetro
			estadoActual = estadoInicial;
		}
		
		
		//Métodos
		
		
		public void ActualizarMaquina()
		{
			//Verificamos si el estado actual es nulo, si lo es, retornamos (o sea este método no hace nada más)
			if(!estadoActual)
				return;
			
			
			
		}

		public void Start()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void CambiarEstado(EstadoMEF nuevoEstado)
		{
			
			
		}
	}
}
