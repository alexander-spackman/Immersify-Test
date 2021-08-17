using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{

    public enum Orientation { X, MinusX, Y, MinusY, Z, MinusZ }

    public Orientation orientation;
    public Transform OriginalPos;
    public Transform ExpandedPos;
     string Name;
    void Start()
    {
        OriginalPos = this.transform;
       // ExpandedPos = this.transform;
    }


    void Update()
    {
        
    }
}
