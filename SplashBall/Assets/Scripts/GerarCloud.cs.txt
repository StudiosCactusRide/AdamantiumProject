using UnityEngine;
using System.Collections;

public class GerarCloud : MonoBehaviour {

	private float currentTimeToSpawn;


	[Header("Tempo maximo para instanciar")][Space(5)]
	public float timeToSpawn;
	[Header("Objetos a serem instanciados")][Space(5)]
	public GameObject[] prefabsObs;

	// Use this for initialization
	void Start () {
		currentTimeToSpawn = timeToSpawn;
	}

	// Update is called once per frame
	void Update () {
		currentTimeToSpawn += Time.deltaTime;
		if (currentTimeToSpawn >= timeToSpawn) {
			Spawn ();
			currentTimeToSpawn = 0;
		}
	}

	void Spawn(){
		int i = Random.Range (0, prefabsObs.Length);
		float y = Random.Range (-5.0f, 7.0f);


		Instantiate (prefabsObs [i], new Vector3(-31,transform.position.y + y, 1), Quaternion.identity);
	}
}
