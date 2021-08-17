using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{

    public enum Orientation { X, MinusX, Y, MinusY, Z, MinusZ }

    public Orientation orientation;
    public Transform OriginalPos;
    public Transform ExpandedPos;
    float targetExpansion = 0f;
    float currentExpansion = 0f;
     string Name;
    void Start()
    {
        OriginalPos = this.transform;
       
    }


    void Update()
    {
        if(currentExpansion != targetExpansion) 
        {
            currentExpansion += 0.01f;

            this.transform.localPosition = (OriginalPos.transform.localPosition + (ExpandedPos.transform.localPosition * currentExpansion));
        }

        if(currentExpansion > targetExpansion) { currentExpansion = targetExpansion; }
        if (currentExpansion < 0) { currentExpansion = 0f; }
    }

   public void Transition(float amount) 
    {
        targetExpansion = amount;
    }
}
