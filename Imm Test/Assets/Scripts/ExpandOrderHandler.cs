using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandOrderHandler : MonoBehaviour
{
    public List<GameObject> Group1 = new List<GameObject>();
    public List<GameObject> Group2 = new List<GameObject>();
    public List<GameObject> Group3 = new List<GameObject>();
    public List<GameObject> Group4 = new List<GameObject>();
    void Start()
    {
        
    }

   
    void Update()
    {
        for (int i = 0; i < Group1.Count; i++) { Group1[i].GetComponent<Part>().Transition(0.15f); }
        for (int i = 0; i < Group2.Count; i++) { Group2[i].GetComponent<Part>().Transition(0.15f); }
        for (int i = 0; i < Group3.Count; i++) { Group3[i].GetComponent<Part>().Transition(0.15f); }
        for (int i = 0; i < Group4.Count; i++) { Group4[i].GetComponent<Part>().Transition(0.15f); }

    }
}
