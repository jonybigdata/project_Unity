using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colcarrot : MonoBehaviour
{
    public static int carrotCount;
    private Text carrotCounter; 

    void Start()
    {
        carrotCounter = GetComponent<Text>();
        carrotCount = 0;     
    }

    
    void Update()
    {
        carrotCounter.text = "X" + carrotCount; 
    }
}
