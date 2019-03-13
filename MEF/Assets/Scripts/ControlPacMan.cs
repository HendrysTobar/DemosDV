
#define ANDROID
using UnityEngine;
using System.Collections;



public class ControlPacMan : MonoBehaviour
{
	CharacterController controller;
	PacMan pacMan = PacMan.Singleton;
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
		
	}

	// Update is called once per frame
	void Update ()
	{
		if(pacMan.estaMuerto)
		{
			return;
		}
		
		float vertical = Input.GetAxis("Vertical");
		//float vertical = -Input.acceleration.y;
		float horizontal = Input.GetAxis("Horizontal");
		//float horizontal = -Input.acceleration.x;
		
#if ANDROID
		Vector3 speed = new Vector3(horizontal, 0, vertical);
#else 
		Vector3 speed = new Vector3();
#endif
#if !ANDROID	
		if(vertical != 0.0f)
		{
			speed = pacMan.velocidad *  new Vector3(0,0, vertical);
		}
		
		if(horizontal != 0.0f)
		{
			speed = pacMan.velocidad *  new Vector3(horizontal,0,0);
		}	
#else
		speed = pacMan.velocidad * speed;
#endif
		
		
		
		controller.SimpleMove(speed);
		
	}
	
	void OnGUI()
	{
		string msg = "";
		if(Input.multiTouchEnabled) msg = "multitouch enabled!";else msg = "Not multitouch enabled!";
		GUI.Label(new Rect(10,70,200,100),msg);
		
		
		GUI.Label(new Rect(10,90,200,100),"Touches: " + Input.touchCount);
		
		GUI.Label(new Rect(10,110,200,100),"Orientacion del dispositivo " + Input.deviceOrientation.ToString());
		
		
		
		GUI.Label(new Rect(10,10,200,100),"Acelaración X: " + Input.acceleration.x);
		GUI.Label(new Rect(10,30,200,100),"Acelaración Y: " + Input.acceleration.y);
		GUI.Label(new Rect(10,50,200,100),"Acelaración Z: " + Input.acceleration.z);
	}
}

