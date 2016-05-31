using UnityEngine;
using System.Collections;

public class SceneScroll : MonoBehaviour {

	private int ScrollSpeed = 10;
	private float Scale_X, Scale_Y, Scale_Z;

	void Start () {

		Scale_X = Random.Range (0.1f, 0.2f);
		Scale_Y = Random.Range (0.3f, 0.5f);
		Scale_Z = Random.Range (0.05f, 0.2f);
			
		transform.localScale = new Vector3 (Scale_X, Scale_Y, Scale_Z);

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = transform.position - new Vector3 (0, 0, 1) * Time.deltaTime * ScrollSpeed;
	
	}

	void OnCollisionEnter(Collision COL) {
	
		if (COL.gameObject.tag == "Wall_Mountains") {
		
			Destroy (this.gameObject);
		}
	}
}
