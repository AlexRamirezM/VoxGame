using UnityEngine;
using System.Collections;

public class SpawnMountain : MonoBehaviour {

	public GameObject PrefabMountain;
	private float Pos_X, Pos_Y, Pos_Z;
	private float CurrentTime;

	// Use this for initialization
	void Start () {

		CurrentTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - CurrentTime > 4) {
		
			CurrentTime = Time.time;

			do {
			
				Pos_X = Random.Range (-130, 30);

			} while(Pos_X <= 20 && Pos_X >= -20);

			Instantiate (PrefabMountain, new Vector3 (Pos_X, 1, 250), Quaternion.Euler(0,Random.Range(0,359),0));


		}
	
	}
}
