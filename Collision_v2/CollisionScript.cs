using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	private bool active = false;

	public GameObject ball;
	public GameObject p1;
	public GameObject p2;

	public Text p1ScoreCount;
	public Text p2ScoreCount;

	private int p1Score;
	private int p2Score;

	// Use this for initialization
	void Start () {

		p1Score = 0;
		p2Score = 0;

		//p1ScoreCount.text = p1Score.ToString ();
		//p2ScoreCount.text = p2Score.ToString ();
	}

	// Update is called once per frame
	void Update () {

//		if ((active == true) && (p1.gameObject.transform.position.x >= 7.6) && (p1.gameObject.transform.position.z <= 2.9) && (p1.gameObject.transform.position.z >= -2.9)) {
//			p1Score++;	
//			p1ScoreCount.text = p1Score.ToString ();
//		}

//		else if ((active == true) && (p2.gameObject.transform.position.x <= -7.6) && (p2.gameObject.transform.position.z <= 2.9) && (p2.gameObject.transform.position.z >= -2.9)) {
//			p2Score++;	
//			p2ScoreCount.text = p2Score.ToString ();
//		}

	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Ball") {
			active = true;

			p1.GetComponent<MoveScript> ().getActive (active);

			ball.transform.parent = p1.transform; 

			ball.transform.localPosition = new Vector3(0, 1, 0);

				
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
	}

	void OnCollisionExit(Collision other){

		if (other.gameObject.tag == "Ball") {

			ball.transform.parent = null;

		}
	}

//	//void OnCollisionEnter(Collision other) {
//		//if ((active == true) && (other.gameObject.tag == "Player")) {
//			ball.gameObject.SetActive (true);	
//			active = false;
//			if (gameObject.name == "Player1") {
//				gameObject.GetComponent<Renderer> ().material.color = Color.blue;
//			} else {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			}
//		}
//	}
}