using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{

    
    public Vector3 OriginalPos;
    public Transform ExpandedPos;
    float targetExpansion = 0f;
    float currentExpansion = 0f;
     string Name;
    void Start()
    {
        OriginalPos = this.transform.localPosition;
       
    }


    void Update()
    {
        if(currentExpansion != targetExpansion) 
        {
            currentExpansion += 0.025f;

            this.transform.localPosition = (OriginalPos + (ExpandedPos.transform.localPosition * currentExpansion));
        }

        if(currentExpansion > targetExpansion) { currentExpansion = targetExpansion; }

        if(targetExpansion == 0f) { this.transform.localPosition = OriginalPos; currentExpansion = 0f;  }
       
    }

   public void Transition(float amount) 
    {
        targetExpansion = amount;
    }
}
