using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed ;
	// Use this for initialization
	void Start () {
		speed = 20;
	}
	
	// Update is called once per frame
	void Update () {
		//moveForward ();
	
	}
	//funcionque mueve al personaje
	public void moveL ()
	{
		Debug.Log ("Hola ");
		//this.transform.position = new Vector3 (3,5,10);
		//this.transform.position = Time.deltaTime * Vector3.right;
		this.transform.Translate ( (Time.deltaTime * speed) * Vector3.left) ;
	}
	//funcionque mueve al personaje
	public void moveR ()
	{
		Debug.Log ("Hola ");
		//this.transform.position = new Vector3 (3,5,10);
		//this.transform.position = Time.deltaTime * Vector3.right;
		this.transform.Translate ( (Time.deltaTime * speed) * Vector3.right) ;
	}
	

}
