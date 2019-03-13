
using System;
using UnityEngine;

/// <summary>
///Esta clase es una clase abstracta. 
//Por lo tanto tiene como mínimo un método abstracto
//No se pueden crear instancias de ella.
//Las clases abstractas DEBEN ser implementadas en las clases hijas
/// </summary>
public abstract class EstadoMEF: MonoBehaviour
{
	public Blinky blinky;
	
	/// <summary>
	///Esto es un método abstracto
	//Por lota tanto no tiene implementación.
	/// </summary>
	public abstract void Salir();
	
	//Metodo  virtual:
	//Un metodo virtual se puede sobrecargar, como los
	//metodos abstractos
	//pero a direferncia de lo abstractos, este debe tener
	//implementacion en la clase padre.
	public virtual void Start()
	{
		blinky = GetComponent<CompBlinky>().b;
	}

    public abstract void Update();
	
	public abstract Type VerificarTransiciones();
	
	public void VerificarCambio()
	{
		//Obtener el estado al cual cambiar
		Type estadoACambiar = VerificarTransiciones();
		//Si el estado nuevo es distinto al estado actual
		if(estadoACambiar != this.GetType())
		//	..Entonces cambiar al nuevo Estado
		{
			CambiarEstado(estadoACambiar);
		}
	}
	
	public void CambiarEstado(Type nuevoEstado)
	{
		//Salir del estado actual
		Salir();
		//Agregar el nuevo estado al objeto en la escena.
		gameObject.AddComponent(nuevoEstado);
		//Destruir este estado
		Destroy(this);
		
	}
	
		
	
	
}