using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovimiento : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Moverse());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Moverse()
    {
        //Mientras que la posición en x sea menor a 0
        while(this.transform.position.x < 0)
        {
            //Moverse Hacia la derecha
            transform.Translate(transform.right * 3 * Time.deltaTime, Space.World);
            yield return null;
        }

        //Toma la decisión de moverse arriba o abajo.

        int r = Random.Range(0, 2);
        //0 = abajo, 1 = arriba
        if(r == 0)
        {
            transform.eulerAngles = new Vector3(0, 0, -45f);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 45f);
        }


        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        transform.localScale *= 2;
        while(sr.isVisible)
        {
            transform.Translate(Vector3.right * 3 * Time.deltaTime, Space.Self);
            yield return null;
        }

        Destroy(this.gameObject);


    }

}
