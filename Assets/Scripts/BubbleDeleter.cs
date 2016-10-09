using UnityEngine;
using System.Collections;

public class BubbleDeleter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float bubbleLife = 10.0f;
        Destroy(gameObject, bubbleLife);
    }
    
}
