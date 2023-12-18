using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRotation : MonoBehaviour
{
    private float rotationSpeed = 0.3f;
    private Vector2 lastTouchPosition;

    void Update()
    {
        // Check for touch input
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    lastTouchPosition = touch.position;
                    break;
                case TouchPhase.Moved:
                    Vector2 delta = touch.position - lastTouchPosition;
                    float rotationX = delta.y * rotationSpeed;
                    float rotationY = -delta.x * rotationSpeed;

                    // Rotate the object based on touch input
                    transform.Rotate(Vector3.up, rotationY, Space.World);
                    transform.Rotate(Vector3.right, rotationX, Space.World);

                    lastTouchPosition = touch.position;
                    break;
            }
        }
    }
}
