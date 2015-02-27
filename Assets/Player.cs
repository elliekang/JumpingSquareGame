using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float jumpScale;
	private int jumpCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space) && jumpCounter < 20) {
	        rigidbody.velocity = new Vector3(0,jumpScale,0);
		jumpCounter++;
	    }

		if (Input.GetKeyUp(KeyCode.Space)) {
			jumpCounter = 50;
		}
	}


	void OnCollisionStay(Collision other) {
		if(!Input.GetKey(KeyCode.Space)) {
			jumpCounter = 0;
		}
	}
}
