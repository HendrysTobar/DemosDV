using System;
using UnityEngine;

[Serializable]
//Singleton: Es una clase, de la cual sólo va a existir una instancia en
//todo el juego.
public class PacMan
{
	//1) Crear un campo cuyo tipo sea esta clase y estático
	private static PacMan instancia = new PacMan();
	
	//2) Crear una propiedad que sea públic y de solo lectura.
	public static PacMan Singleton
	{
		//esto hace que sea de solo lectura
		get
		{
			return instancia;
		}
	}
		
	//3) Un Constructor privado
	private PacMan()
	{
		
	}
		
	//Campos
	public bool estaFurioso = false;
	public int cantidadDeVidas = 3;
	public bool estaMuerto = false;
	public GameObject objetoEscena;	
	public float velocidad = 2.0f;
	
	
}


