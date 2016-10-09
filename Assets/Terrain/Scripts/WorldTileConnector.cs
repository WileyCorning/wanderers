using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(SphereCollider))]
public class WorldTileConnector : MonoBehaviour {

	public WorldModel world;
	public WorldTileConnector neighbor;

	public event Action OnSpawnTrigger;
	public void Start() {
		world = GetComponentInParent<WorldModel> ();
		GetComponent<SphereCollider> ().isTrigger = true;
		GetComponent<SphereCollider> ().enabled = true;
	}

	void OnTriggerStay(Collider other) {
		if (neighbor != null) {
			return;
		}
		SpawnNeighbor ();
	}

	public void SetNeighbor(WorldTileConnector _neighbor) {
		neighbor = _neighbor;
		_neighbor.neighbor = this;
		neighbor.enabled = false;
		this.enabled = false;
	}

	public void SpawnNeighbor() {
		// Temp
		GameObject prefab = world.tempPrefab;

		GameObject node = (GameObject)Instantiate (prefab,world.transform);

		WorldTileConnector[] nodeConnectors = node.GetComponentsInChildren<WorldTileConnector> ();

		// Temp
		int idx = UnityEngine.Random.value > 0.5f ? 0 : 1;
		WorldTileConnector nextConn = nodeConnectors [idx];

		SetNeighbor (nextConn);


		// Align connectors
		Vector3 translation = nextConn.transform.position - transform.position;

		node.transform.position -= translation;

		float angle = Vector3.Angle (transform.forward, -nextConn.transform.forward);
		node.transform.RotateAround (transform.position, Vector3.up, -angle);


	}
}