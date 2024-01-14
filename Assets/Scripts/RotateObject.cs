using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private float rotationSpeed = 3.0f; // Adjust the rotation speed based on your preference

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //float rotationX = -touchDeltaPosition.y * rotationSpeed * Time.deltaTime; // Rotate around the Y-axis
            float rotationX = touchDeltaPosition.x * rotationSpeed * Time.deltaTime;  // Rotate around the Z-axis

            // Only rotate around the Y and Z axes
            transform.Rotate(Vector3.up * rotationX, Space.World);
            //transform.Rotate(Vector3.forward * rotationZ, Space.World);
        }
    }
}


