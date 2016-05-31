using UnityEngine;
using System.Collections;

public class PlaneRotation : MonoBehaviour {

	private float RotateSpeed = 10f;
	private float RotateRange;
	public Vector3 InitialAngle;
	public bool Rotated;

	void Start() {
	
		InitialAngle = transform.eulerAngles;
		RotateRange = Random.Range (10, 15);
	}

	void Update ()
	{
		
		transform.Rotate (Vector3.up, RotateSpeed * Time.deltaTime);

		if (transform.eulerAngles.x - InitialAngle.x > RotateRange && Rotated == false) {

			RotateSpeed = RotateSpeed * -1;
			RotateRange = Random.Range (10, 15);
			Rotated = true;
		}

		if (transform.eulerAngles.x >= 269 && transform.eulerAngles.x <= 271) {
			Rotated = false;
		}
	}
}
