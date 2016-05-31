using UnityEngine;
using System.Collections;

public class SpawnNota : MonoBehaviour {

	AudioSource Sonido;
	public GameObject RustyBarrelPrefab;
	public GameObject GoldBarrelPrefab;
	private int z;
	private float BPM;
	private float R,B,N,C,S;
	public int[] Notas;
	public float[] Figuras;


	// Use this for initialization
	void Start () {

		BPM = 120;

		N = 1 / (BPM / 60);	//Negra
		R = N * 4;			//Redonda
		B = N * 2;			//Blanca
		C = N / 2;			//Corchea
		S = C / 2;			//SemiCorchea

		Notas = 	new int[] {60,70,80,50,60,70,80,50,60,70,80,50,60,70,80,80, 6,6,6,6,6,6,6,5,8,8,8,8,8,8,8,5,6,6,6,6,6,6,6,5,8,8,8,8,7,7,7,5, 6,6,6,6,6,6,6,5,8,8,8,8,8,8,8,5,6,6,6,6,6,6,6,5,8,8,8,8,7,7,7,5, 4,2,5,6,6,4,4,8,5,6,6,6,7, 6,7,8,5,6,7,8,5,6,7,8,5,6,7,8,5,60,70,80,50,60,70,80,50,60,70,80,50,60,70,80, 5,3,2,2,2,2,   6,6,6,6,6,6,6,5,8,8,8,8,8,8,8,5,6,6,6,6,6,6,6,5,8,8,8,8,7,7,7,5, 6,6,6,6,6,6,6,5,8,8,8,8,8,8,8,5,60,6,60,6,60,6,60,5,80,8,80,8,70,7,70,5, 4,2,5,6,6,4,4,8,5,6,6,6,7, 6,7,8,5,6,7,8,5,6,7,8,5,6,7,8,5,6,70,80,5,6,70,80,5,6,70,80,5,6,70,80,};
		Figuras = new float[] {B,B,B,B,B,B,B,B,B,B,B,B,B,B,R,R, N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N, N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N, B,B,R,R,B,B,B,B,R,R,B,N,N, B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B, N,N,R,R,R,R,   N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N, N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N,N, B,B,R,R,B,B,B,B,R,R,B,N,N, B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,};

		Sonido = GetComponent<AudioSource> ();
		z = 40;

		StartCoroutine (Cancion ());

	}

	IEnumerator Cancion() {

		yield return new WaitForSeconds (2);

		Sonido.Play ();

		for (int i = 0; i < Notas.Length; i++) {

			if (Notas [i] > 8) { 

				Instantiate (GoldBarrelPrefab, new Vector3 (0, (Notas [i] / 10) * 2, z), Quaternion.identity);

			} else {
			
				Instantiate (RustyBarrelPrefab, new Vector3 (0, Notas [i] * 2, z), Quaternion.identity);
			}

			yield return new WaitForSeconds (Figuras[i]);

		}
	}

}
