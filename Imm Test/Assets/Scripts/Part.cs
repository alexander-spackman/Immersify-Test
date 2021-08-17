using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{

    
    public Vector3 OriginalPos;     
    public Transform ExpandedPos;
    float targetExpansion = 0f;
    float currentExpansion = 0f;
    public string Name;
    void Start()
    {
        OriginalPos = this.transform.localPosition;     //saves the original position on start
       
    }


    void Update()
    {
        if(currentExpansion != targetExpansion) 
        {
            currentExpansion += 0.025f;     //gradually moves the part from it's start point to it's desination

            this.transform.localPosition = (OriginalPos + (ExpandedPos.transform.localPosition * currentExpansion));
        }

        if(currentExpansion > targetExpansion) { currentExpansion = targetExpansion; }  //prevents overshooting

        if(targetExpansion == 0f) { this.transform.localPosition = OriginalPos; currentExpansion = 0f;  }   //if the target has been reset, resets the object to start point
       
    }

   public void Transition(float amount) 
    {
        targetExpansion = amount;
    }
}
