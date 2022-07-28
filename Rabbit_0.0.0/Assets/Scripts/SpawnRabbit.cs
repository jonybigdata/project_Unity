using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRabbit : MonoBehaviour
{
    public GameObject carrot;
    public float Seconds = 1.0f;
    
    
    void Start()
    {
     StartCoroutine (Spawn ());   //
     StartCoroutine (Accelerate ());
     
    }


    IEnumerator Accelerate () {
        while (true){
        Seconds=Seconds - 0.02f;
        yield return new WaitForSeconds (1f);
        }
    }

    IEnumerator Spawn(){
        while(!loos.los){
            Instantiate (carrot, new Vector2(Random.Range (0.5f, 16f), 19f), Quaternion.identity);
            yield return new WaitForSeconds (Seconds);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
