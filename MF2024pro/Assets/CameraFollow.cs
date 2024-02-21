using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // 玩家物体的Transform
    public float rotateSpeed = 5f;
    public float lerpSpeed = 2f;

    private Vector3 offset;
    private bool isRotating = false;

    void Start()
    {
        offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float horizontalInput = Input.GetAxis("Mouse X");

            if (target != null)
            {
                float angle = horizontalInput * rotateSpeed;
                offset = Quaternion.AngleAxis(angle, Vector3.up) * offset;
                transform.position = target.position + offset;
                transform.LookAt(target);
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpSpeed * Time.deltaTime);
            transform.LookAt(target);
        }
    }
}
