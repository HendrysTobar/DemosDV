using UnityEngine;
using System.Collections;

public class CompGuerrero : MonoBehaviour {
	
		
	
	public float largoDeEje;
	
	
	public float angle;
	
	
	// Use this for initialization
	void Start () 
	{
		
		
		
	}
	
	
	
	
	// Update is called once per frame
	void Update ()
	{
		
		angle = Quaternion.Angle(transform.rotation, Quaternion.identity);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.time * 0.00003f);
		
		
			
	}
	
	
	void OnDrawGizmos()
	{	
		#region Gizmos de los ejes
		//Pintar los ejes del espacio vectorial
		Gizmos.DrawLine(100 * Vector3.down, 100* Vector3.up );		
		Gizmos.DrawLine(100 * Vector3.left, 100* Vector3.right );		
		Gizmos.DrawLine(100 * Vector3.back, 100* Vector3.forward );		
		
		//Pintar los ejes locales de este objeto
		Gizmos.color = Color.yellow;
		Gizmos.DrawLine(transform.position + largoDeEje * -transform.up, transform.position +  largoDeEje * transform.up );				
		Gizmos.DrawLine(transform.position + largoDeEje * -transform.right, transform.position + largoDeEje * transform.right );		
		Gizmos.DrawLine(transform.position + largoDeEje * -transform.forward, transform.position + largoDeEje * transform.forward );
		#endregion		
		
	}
	
}
