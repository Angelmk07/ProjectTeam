using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    private float moveSpeed = 0.6f;
    private float minX = -8f;
    private float maxX = 8f;
    private float minY = -4.53f;
    private float maxY = 4.53f; 

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            Vector3 newPosition = transform.position;
            newPosition.x += mouseX * moveSpeed;
            newPosition.y += mouseY * moveSpeed; 
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
            newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
            transform.position = newPosition; 
        }
    }
}
