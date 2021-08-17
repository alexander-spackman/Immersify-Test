using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NameHandler : MonoBehaviour
{
    string RawInput;
    string[] Names;
    public ExpandOrderHandler Expander;
    string Tag;
    GameObject[] Parts;


    void Start()
    {
         RawInput = System.IO.File.ReadAllText(Application.dataPath + "/CSV/PartNames.csv");    //reads csv
        Names = RawInput.Split(',');                                                            //splits into seperate values


        Parts = GameObject.FindGameObjectsWithTag("P1");            //finds all objects of each type via tag and changes their "name" value to the corresponding value froim the csv file
        Name(Names[0]);

        Parts = GameObject.FindGameObjectsWithTag("P2");
        Name(Names[1]);

        Parts = GameObject.FindGameObjectsWithTag("P3");
        Name(Names[2]);

        Parts = GameObject.FindGameObjectsWithTag("P4");
        Name(Names[3]);

        Parts = GameObject.FindGameObjectsWithTag("P5");
        Name(Names[4]);

        Parts = GameObject.FindGameObjectsWithTag("P6");
        Name(Names[5]);

        Parts = GameObject.FindGameObjectsWithTag("P7");
        Name(Names[6]);

        Parts = GameObject.FindGameObjectsWithTag("P8");
        Name(Names[7]);

        Parts = GameObject.FindGameObjectsWithTag("P9");
        Name(Names[8]);

        Parts = GameObject.FindGameObjectsWithTag("P10");
        Name(Names[9]);

        Parts = GameObject.FindGameObjectsWithTag("P11");
        Name(Names[10]);

        Parts = GameObject.FindGameObjectsWithTag("P12");
        Name(Names[11]);

       


    }

    // Update is called once per frame
    void Name(string name)  //names the current contents of "Parts[]"
    {
        for(int i = 0; i < Parts.Length; i++) 
        {
            Parts[i].GetComponent<Part>().Name = name;
        }
    }
}
