using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed;

	public KeyCode p1Throw = KeyCode.Space;
	public GameObject ball;

	private Rigidbody rb;
	private bool armed;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();

	}

	public void getActive(bool active){
		armed = active;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (gameObject.name == "Player1") {
			transform.Translate (Input.GetAxis ("p1H") * speed * Time.deltaTime, 0, Input.GetAxis ("p1V") * speed * Time.deltaTime);

			if (armed) {
				if (Input.GetKeyDown (p1Throw)) {



					ball.transform.Translate (Input.GetAxis ("p1H") * 300 * Time.deltaTime, 0, Input.GetAxis ("p1V") * speed * Time.deltaTime);
					
				}

			} 

		}
		//else {
			//transform.Translate (Input.GetAxis ("p2H") * speed * Time.deltaTime, 0, Input.GetAxis ("p2V") * speed * Time.deltaTime);
		//}

	}
}