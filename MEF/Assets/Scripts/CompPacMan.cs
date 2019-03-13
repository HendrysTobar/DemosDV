using UnityEngine;
using System.Collections;

public class CompPacMan : MonoBehaviour
{
	public PacMan pacMan = PacMan.Singleton;
	

	#region Campos
	Vector3 spawnPoint;
	bool fading = false;
	bool spawn = false;
	
	Material materialPacMan;
	public AudioClip pac;
	Color colorOriginal;
	AudioSource sourceLoopPac;
	
	public float tiempoDeFuria = 5.0f;
	#endregion
	
	
	// Use this for initialization
	void Start ()
	{
		#region Inicializacion
		pacMan.objetoEscena = this.gameObject;
		spawnPoint = this.transform.position;
		materialPacMan = transform.GetChild(0).GetComponent<Renderer>().material;
		
		colorOriginal =materialPacMan.color;
		sourceLoopPac = GetComponents<AudioSource>()[1];
		#endregion
	}

	// Update is called once per frame
	void Update ()
	{
		#region Actualizacion
			if(pacMan.estaMuerto)
			{
				fading = true;
			}
			
			if(fading)
				Fade();
			
			if(spawn)
				ReSpawn();
			
			if(pacMan.estaFurioso)
				Fury();
			#endregion
		
	}
	
	void OnTriggerEnter(Collider hit)
	{	
		#region Si se choca con la comida
		if(hit.tag.StartsWith("Comida"))
		{
			Destroy(hit.gameObject);
			GetComponent<AudioSource>().PlayOneShot(pac);
		}
		#endregion
		
		#region Si se choca con la comida grande
		if(hit.tag.StartsWith("ComidaGrande"))
		{
			
			pacMan.estaFurioso = true;
			
		}
		#endregion
			
	}
	
	void Fury()
	{
		#region Furia de PacMan
		if(!sourceLoopPac.isPlaying)
		{
			sourceLoopPac.Play();
		}
		
		tiempoDeFuria-= Time.deltaTime;
		if(tiempoDeFuria <= 0.0f)
		{
			pacMan.estaFurioso = false;
			materialPacMan.color = colorOriginal;
			tiempoDeFuria = 5.0f;
			sourceLoopPac.Stop();
		}
		#endregion
		
	}
	
	void ReSpawn()
	{
		#region Reaparecer
		this.transform.position = spawnPoint;
		materialPacMan.color = colorOriginal;
		
		pacMan.estaMuerto = false;
		spawn = false;
		#endregion
	}
	
	void Fade()
	{
		#region Desvanecerse
		Color newColor = materialPacMan.color;
		newColor.a -= 0.004f;;
		
		if(newColor.a <= 0)
		{
			fading = false;
			spawn = true;
		}
		
		materialPacMan.color = newColor;
		#endregion		
	}
	
	
	
	
}

