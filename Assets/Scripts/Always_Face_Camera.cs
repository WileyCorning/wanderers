using UnityEngine;
using System.Collections;

public class Always_Face_Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Camera.main.transform.position);
        transform.LookAt(Camera.main.transform.position, Vector2.right);
        //transform.Rotate(Vector2.right);
    }
}
