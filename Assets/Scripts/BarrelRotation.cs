using UnityEngine;
using System.Collections;

public class BarrelRotation : MonoBehaviour {

	private float speed = 100f;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
