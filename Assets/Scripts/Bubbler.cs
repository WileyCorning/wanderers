using UnityEngine;
using System.Collections;

public class Bubbler : MonoBehaviour {
    public const float spawnDist = 12.0f;
    Ray ray;
    RaycastHit hit;
    public GameObject Bubble;

    public float maxScale = 1f;
    public double currentScale = 0;
    public float scaleSpeed = 1f;

    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (GvrController.TouchDown)
        {
            Debug.Log("A");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, spawnDist))
            {
                GameObject obj = (GameObject)Instantiate(Bubble);
                obj.transform.position = hit.point;

            }
            else
            {
                GameObject obj = (GameObject)Instantiate(Bubble);
                obj.transform.position = GetComponent<Camera>().transform.position + GetComponent<Camera>().transform.forward * spawnDist;
                
            }


            }


        }
    }

