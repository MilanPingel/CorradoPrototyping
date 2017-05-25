using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject coinPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3 (Random.Range (-10f, 10f), 0, Random.Range (-10f,10f));
            Vector3 randomSpawnRotation = Vector3.up * Random.Range (0, 360);

			GameObject NewCoin = (GameObject) Instantiate (coinPrefab, randomSpawnPosition, Quaternion.Euler (randomSpawnRotation));
			NewCoin.transform.parent = transform;
        }
	}
}
