using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text textObj;
	public float Points = 0;

	// Use this for initialization
	void Start () {

		textObj = GameObject.Find ("Score").GetComponent<Text> ();

	}

	void OnCollisionEnter(Collision KOL) {

		if(KOL.gameObject.tag == "RustyBarrel") {

			Points = Points + 100;
			textObj.text = Points.ToString();
		}

		if(KOL.gameObject.tag == "GoldBarrel") {

			Points = Points + 300;
			textObj.text = Points.ToString();
		}
	}
}
