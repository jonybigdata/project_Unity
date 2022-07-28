using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colHP : MonoBehaviour
{
    public static int hpcount;
    private Text hpcounter; 

    void Start()
    {
        hpcounter = GetComponent<Text>();
        hpcount = 3;     
    }

    
    void Update()
    {
        hpcounter.text = "X" + hpcount; 
    }
}
