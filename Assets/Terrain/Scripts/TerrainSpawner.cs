using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof(Collider))]
public class TerrainSpawner : MonoBehaviour {
	public event Action OnSpawnTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<PlayerController> () != null) {
			OnSpawnTrigger ();
		}
	}

	public static GameObject Make(float radius = 1) {
		GameObject go = new GameObject ();
		SphereCollider s = go.AddComponent<SphereCollider> ();
		s.isTrigger = true;
		s.radius = radius;
		go.AddComponent<TerrainSpawner> ();
		return (GameObject)Instantiate (go);
	}
}
