using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObject : MonoBehaviour
{
    public float zoomSpeed = 0.5f;
    public float minZoom = 0.5f;
    public float maxZoom = 5f;

    void Update()
    {
        // Check for pinch gesture
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Adjust the zoom based on pinch gesture (inverted)
            Zoom(-deltaMagnitudeDiff * zoomSpeed * Time.deltaTime);
        }
    }

    void Zoom(float deltaMagnitudeDiff)
    {
        // Modify the object's scale based on pinch gesture
        Vector3 newScale = transform.localScale + new Vector3(deltaMagnitudeDiff, deltaMagnitudeDiff, deltaMagnitudeDiff);

        // Clamp the scale to minZoom and maxZoom values
        newScale.x = Mathf.Clamp(newScale.x, minZoom, maxZoom);
        newScale.y = Mathf.Clamp(newScale.y, minZoom, maxZoom);
        newScale.z = Mathf.Clamp(newScale.z, minZoom, maxZoom);

        // Apply the new scale to the object
        transform.localScale = newScale;
    }
}
