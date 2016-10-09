using UnityEngine;
using System.Collections;

public class FaceTargetScript : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
            transform.rotation = target.rotation;
    }
}
