using UnityEngine;
using System.Collections;

public class PropellerRotate : MonoBehaviour {

	float speed = 1000f;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
