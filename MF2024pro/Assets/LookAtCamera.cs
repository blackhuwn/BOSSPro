using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform mainCameraTransform;

    void Start()
    {
        mainCameraTransform = GameObject.FindObjectOfType<Camera>().transform;
    }

    void Update()
    {
        transform.LookAt(mainCameraTransform);
    }
}
