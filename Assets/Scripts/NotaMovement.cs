using UnityEngine;
using System.Collections;

public class NotaMovement : MonoBehaviour {

	private float Speed = 10;
	private Vector3 Position;

	public Vector3 StartPosition;
	public Vector3 EndPosition;

	float CurrentTime;
	public float journeyFraction;

	public float[] Poz = new float[9];
	private float TestTime;
	int p = 0;

	// Use this for initialization
	void Start () {

		StartPosition = transform.position;
		EndPosition = new Vector3 (0, StartPosition.y, -20);
//		TestTime = 0;
	}
	
	// Update is called once per frame
	void Update () {

		float Step = Speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, EndPosition, Step);

//		if (Time.time - TestTime >= 0.5f && p < 9) {
//
//			TestTime = Time.time;
//			Poz [p] = transform.position.z;
//			print (Time.time);
//			p += 1;
//		}
			
	}

	void OnCollisionEnter(Collision COL) {
	
		if (COL.gameObject.tag == "Wall") {
		
			Destroy(this.gameObject);
		}

		if (COL.gameObject.tag == "Player") {

			Destroy (this.gameObject);
		}
	}
}
