using UnityEngine;
using System.Collections;

public class GerarBolas : MonoBehaviour {

	private float currentTimeToSpawn;
	private float timeToSpawn;


	[Header("Objetos a serem instanciados")][Space(5)]
	public GameObject[] prefabsObs;

	// Use this for initialization
	void Start () {
		timeToSpawn = 2.0f;
		currentTimeToSpawn = timeToSpawn;
	}
	
	// Update is called once per frame
	void Update () {
		currentTimeToSpawn += Time.deltaTime;
		if (currentTimeToSpawn >= timeToSpawn) {
			Spawn ();
			currentTimeToSpawn = 0;
			timeToSpawn -= 0.03f;
		}
	}

	void Spawn(){
		int i = Random.Range (0, prefabsObs.Length);
		float x = Random.Range (-10.0f, 10.0f);

		Instantiate (prefabsObs [i], new Vector3(x,transform.position.y , 0), Quaternion.identity);
	}
}
