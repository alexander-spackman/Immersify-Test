﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExpandOrderHandler : MonoBehaviour
{
    public List<GameObject> Group1 = new List<GameObject>();
    public List<GameObject> Group2 = new List<GameObject>();
    public List<GameObject> Group3 = new List<GameObject>();
    public List<GameObject> Group4 = new List<GameObject>();
    public bool Expand = false;
    int layer = 0;
    float timer = 0;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5) { layer++; timer = 0; }
        

        if (layer == 1) { for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(0.25f); } }
            
        if (layer == 2) 
        {
            for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(0.5f); }
            for (int i = 0; i < Group2.Count; i++) { Group2[i].GetComponent<Part>().Transition(0.5f); }
        }
        
        if (layer == 3) 
        {
            for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(0.75f); }
            for (int i = 0; i < Group2.Count; i++) { Group2[i].GetComponent<Part>().Transition(0.75f); }
            for (int i = 0; i < Group3.Count; i++) { Group3[i].GetComponent<Part>().Transition(0.75f); }
        }
        
        if (layer == 4) 
        {
            for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(1.0f); }
            for (int i = 0; i < Group2.Count; i++) { Group2[i].GetComponent<Part>().Transition(1.0f); }
            for (int i = 0; i < Group3.Count; i++) { Group3[i].GetComponent<Part>().Transition(1.0f); }
            for (int i = 0; i < Group4.Count; i++) { Group4[i].GetComponent<Part>().Transition(1.0f); }
        }

        if(!Expand) { reset(); }
        
    }

    void reset() 
    {
       for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(0f); } 
       for (int i = 0; i < Group2.Count; i++) { Group2[i].GetComponent<Part>().Transition(0f); } 
       for (int i = 0; i < Group3.Count; i++) { Group3[i].GetComponent<Part>().Transition(0f); } 
       for (int i = 0; i < Group4.Count; i++) { Group4[i].GetComponent<Part>().Transition(0f); }
       
        layer = 0;
    }
}
