using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	private int i;
	// Use this for initialization
	void Start () {
		i = Random.Range (-15, 15);
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
		SelfDestroy ();
	}

	void Rotate(){
		
		this.gameObject.transform.eulerAngles = new Vector3 (0f, 0f, transform.eulerAngles.y -i);
		if (i > 0) {
			i+=5;
		} else {
			i-=5;
		}
	}

	void SelfDestroy(){
		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}
}
