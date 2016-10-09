using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization

	public Camera cam;

	public Vector3 velocity { get { return rb.velocity; } }
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posInc = cam.transform.forward;
		transform.position += new Vector3 (posInc.x, 0, posInc.z)*Time.deltaTime*2;
		//transform.position += new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * 100 * Time.deltaTime;
	}
}
