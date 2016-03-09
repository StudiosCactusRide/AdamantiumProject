using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	private float vel;


	// Use this for initialization
	void Start () {
		vel = Random.Range (0.8f, 5.0f);
	}

	// Update is called once per frame
	void Update () {
		MoveCloud ();
	}

	void MoveCloud(){
		transform.Translate (vel * Time.deltaTime, 0, 0);

		if (transform.position.x > 36) {
			Destroy (gameObject);
		}
	}
}
