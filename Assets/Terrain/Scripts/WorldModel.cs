using System;
using UnityEngine;
using System.Collections.Generic;

public class WorldModel : MonoBehaviour
{
	bool justOne = false;
	public PlayerController player;
	public GameObject[] nodePrefabs;
	public  GameObject tempPrefab;
	public GameObject cloudPrefab;

	public CloudController[] clouds;

	public void Start()
	{
		nodePrefabs = new GameObject[]{ tempPrefab };


		GameObject root = (GameObject)Instantiate (tempPrefab, this.transform);

		WorldTileConnector[] rootConn = root.GetComponentsInChildren<WorldTileConnector> ();

		clouds = new CloudController[25];

		for (int i = 0; i < clouds.Length; i++) {
			GameObject cloudGO = (GameObject)Instantiate (cloudPrefab);
			clouds [i] = cloudGO.GetComponent<CloudController> ();
			cloudGO.transform.position = player.transform.position + Vector3.up * 5 + Vector3.up * UnityEngine.Random.value * 10;
			cloudGO.transform.position += (UnityEngine.Random.value-0.5f) * Vector3.forward * 100 + (UnityEngine.Random.value-0.5f) * Vector3.right * 100;

		}
	}

	public void Update() {
		foreach(CloudController cloud in clouds) {
			if (cloud.t > cloud.lim) {
				cloud.Reset ();
				cloud.transform.position = player.transform.position + Vector3.up * 75;
				cloud.transform.position += (UnityEngine.Random.value-0.5f) * Vector3.forward * 100 + (UnityEngine.Random.value-0.5f) * Vector3.right * 100;
			}
		}
	}
}