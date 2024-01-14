using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    private Vector3 initialScale;
    private float scaleFactor = 0.01f; // Adjust the scale factor based on your preference

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            Vector2 touch0PrevPos = touch0.position - touch0.deltaPosition;
            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;

            float prevTouchDeltaMag = (touch0PrevPos - touch1PrevPos).magnitude;
            float touchDeltaMag = (touch0.position - touch1.position).magnitude;

            float deltaMagnitudeDiff = touchDeltaMag - prevTouchDeltaMag;

            Vector3 newScale = transform.localScale + new Vector3(deltaMagnitudeDiff, deltaMagnitudeDiff, deltaMagnitudeDiff) * scaleFactor;

            // Limit the scale to avoid undesirable results
            newScale = new Vector3(Mathf.Clamp(newScale.x, 0.1f, 5f),
                                   Mathf.Clamp(newScale.y, 0.1f, 5f),
                                   Mathf.Clamp(newScale.z, 0.1f, 5f));

            transform.localScale = newScale;
        }
    }
}
