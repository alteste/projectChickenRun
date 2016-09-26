using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (gameObject.name == "Player1") {
			transform.Translate (Input.GetAxis ("p1H") * speed * Time.deltaTime, 0, Input.GetAxis ("p1V") * speed * Time.deltaTime);
		} 
		else {
			transform.Translate (Input.GetAxis ("p2H") * speed * Time.deltaTime, 0, Input.GetAxis ("p2V") * speed * Time.deltaTime);
		}
	
	}
}
