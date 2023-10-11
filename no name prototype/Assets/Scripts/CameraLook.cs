using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour

{

    public float sensitivity = 2.0f; // Adjust the sensitivity of camera movement
    public float minYAngle = -80.0f; // Minimum vertical angle
    public float maxYAngle = 80.0f;  // Maximum vertical angle

    private float rotationX = 0;

    void Start()
    {
        
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
           
            mainCamera.transform.rotation = Quaternion.identity;
        }
        else
        {
            Debug.LogError("Main camera not found.");
        }
    }

    
    void Update()
    {
        // Get the mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera horizontally based on mouse X input
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + (mouseX * sensitivity), 0);

        // Calculate the new vertical rotation angle
        rotationX -= mouseY * sensitivity;

        // Clamp the vertical rotation angle to the specified range
        rotationX = Mathf.Clamp(rotationX, minYAngle, maxYAngle);

        // Apply the rotation to the camera
        transform.localEulerAngles = new Vector3(rotationX, transform.localEulerAngles.y, 0);

    }
}

