using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loos : MonoBehaviour
{
    public static bool los = false; 
    public GameObject restart;


    void Awake() {
        los = false;   
    }

    void Start()
    {
        
    }

    
    void Update()
    {
    if (colHP.hpcount == 0){
        los = true;
        restart.SetActive (true);
    }    
    }
}
