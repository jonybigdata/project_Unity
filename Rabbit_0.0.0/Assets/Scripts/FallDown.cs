using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FallDown : MonoBehaviour
{
    
    public static float fallspeed=7.0f; 
    public bool eez = true;
    //public float chengeSpeed = 0.01f;
   
    // Start is called before the first frame update

    

    void Start()
    {
        StartCoroutine (Accelerate ());
    }
    
    IEnumerator Accelerate () {
        
        while (eez){
        fallspeed=fallspeed + 0.5f;
        yield return new WaitForSeconds (1f);
        if (fallspeed == 10f){
            eez = false; 
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!loos.los){
        while(transform.position.y <= -12f)
        if(transform.position.y <= -12f)
            {
                colHP.hpcount -=1;
                Destroy(this.gameObject);
                break;
                
            }
        }
            

        //fallspeed += Time.deltaTime * chengeSpeed;
        //transform.Translate(0, -fallspeed * Time.deltaTime, 0);
        transform.position -= new Vector3(0, fallspeed*Time.deltaTime,0);

        
    }
}
