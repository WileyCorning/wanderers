using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
	public float lim=0;
	public float t = 0;
	// Use this for initialization
	void Start () {
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
	}

	public void Reset() {
		transform.localRotation = Quaternion.AngleAxis(Random.value * Mathf.PI*2, Vector3.up);
		gameObject.transform.localScale = new Vector3 (100, 100, 100) + new Vector3 (Random.value * 250, Random.value * 250, Random.value * 250);
		lim = Random.value * 100;
		t = 0;
	}
}
