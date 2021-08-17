using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    float RotationSpeed = 15;                       //controls rotation speed to input ratio
    public ExpandOrderHandler ExpandHandler;
  
    bool TimerOn = false;
    float timer = 0;
    void OnMouseDrag() 
    {
        
        float xRotation = Input.GetAxis("Mouse X") * RotationSpeed * Mathf.Deg2Rad;         //gets mouse X & Y axis and translates to radians
        float yRotation = Input.GetAxis("Mouse Y") * RotationSpeed * Mathf.Deg2Rad;

        this.GetComponent<Transform>().RotateAround(Vector3.up, -xRotation);                //Rotates object around correct axis
        this.GetComponent<Transform>().RotateAround(Vector3.right, yRotation);
    }
    void OnMouseUp() { TimerOn = false; timer = 0; }        //for timing how long the mouse is held down for
    void OnMouseDown() { TimerOn = true; }

    void OnMouseUpAsButton()            //Using OnMouseDown for input interferes with drag so used mouseUpAsButton to detect clicks on the collider and a timer to make sure it doesn't go off after a drag event 
    {
        if ( timer<0.2)
        {
            ExpandHandler.Expandable = !ExpandHandler.Expandable;   //inverts the expansion state
        }
    }

    void Update() { if (TimerOn) { timer += Time.deltaTime; } }     //just for the timer
}
