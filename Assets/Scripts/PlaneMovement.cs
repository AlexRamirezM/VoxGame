using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour {

	public GameObject MicObject;
	public Mic MicScript;
	public int Height;
	public float Speed = 0.2f;

	// Use this for initialization
	void Start () {

		MicObject = GameObject.Find ("Mic");
		MicScript = MicObject.GetComponent<Mic> ();
		Height = (int)MicScript.SingingNote;
	
	}
	// Update is called once per frame
	void Update () {
		
		Height = (int)MicScript.SingingNote;
		transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, Height * 2, -2.5f), Speed);
	}

}
