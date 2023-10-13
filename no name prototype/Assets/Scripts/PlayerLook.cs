using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;

    public float ySensitivity = 30f;

    //public float sensitivity = 2.0f; // Adjust the sensitivity of camera movement
    //public float minYAngle = -80.0f; // Minimum vertical angle
    //public float maxYAngle = 80.0f;  // Maximum vertical angle

    private float rotationX = 0;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x / Screen.width;
        float mouseY = input.y / Screen.width;

        xRotation -= (mouseY * Time.deltaTime) * xSensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }





    // Start is called before the first frame update
    void Start()
    {
        //Camera mainCamera = Camera.main;

        //if (mainCamera != null)
        //{

        //    mainCamera.transform.rotation = Quaternion.identity;
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        //// Get the mouse input
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        //// Rotate the camera horizontally based on mouse X input
        //transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + (mouseX * sensitivity), 0);

        //// Calculate the new vertical rotation angle
        //rotationX -= mouseY * sensitivity;

        //// Clamp the vertical rotation angle to the specified range
        //rotationX = Mathf.Clamp(rotationX, minYAngle, maxYAngle);

        //// Apply the rotation to the camera
        //transform.localEulerAngles = new Vector3(rotationX, transform.localEulerAngles.y, 0);

    }
}
