using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    float RotationSpeed = 15;
    public ExpandOrderHandler ExpandHandler;
  
    bool TimerOn = false;
    float timer = 0;
    void OnMouseDrag() 
    {
        
        float xRotation = Input.GetAxis("Mouse X") * RotationSpeed * Mathf.Deg2Rad;
        float yRotation = Input.GetAxis("Mouse Y") * RotationSpeed * Mathf.Deg2Rad;

        this.GetComponent<Transform>().RotateAround(Vector3.up, -xRotation);
        this.GetComponent<Transform>().RotateAround(Vector3.right, yRotation);
    }
    void OnMouseUp() { TimerOn = false; timer = 0; }
    void OnMouseDown() { TimerOn = true; }

    void OnMouseUpAsButton() 
    {
        if ( timer<0.2)
        {
            ExpandHandler.Expand = !ExpandHandler.Expand;
        }
    }

    void Update() { if (TimerOn) { timer += Time.deltaTime; } }
}
