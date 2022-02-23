using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    public float sensativity = 3f;
    float xRotation = 0f;

    public Transform Camera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensativity;
        float mouseY = Input.GetAxis("Mouse Y") * sensativity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Camera.Rotate(Vector3.up * mouseX);
    }
}
