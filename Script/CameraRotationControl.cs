using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationControl : MonoBehaviour
{
    public float min_value = 0;
    public float max_value = 0;
    public float mouse_speedY = 3.0f;
    float rotationY = 0f;

    void Update()
    {
        rotationY -= Input.GetAxis("Mouse Y") * mouse_speedY;
        rotationY = Mathf.Clamp(rotationY, min_value, max_value);

        transform.localEulerAngles = new Vector3(rotationY, 0, 0);
    }
}
