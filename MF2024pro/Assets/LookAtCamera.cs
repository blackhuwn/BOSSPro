using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform mainCameraTransform;
    public GameObject Child;

    void Start()
    {
        mainCameraTransform = GameObject.FindObjectOfType<Camera>().transform;
        float xV = -Child.transform.localScale.x;
        Child.transform.localScale = new Vector3(xV, Child.transform.localScale.y, Child.transform.localScale.z);
        //    Child.transform.rotation
    }

    void Update()
    {
        transform.LookAt(mainCameraTransform);

    }
}

    

