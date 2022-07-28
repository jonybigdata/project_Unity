using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform player1;
    [SerializeField]
    private float speed = 100f; 

    void OnMouseDrag() {
        if(!loos.los){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
        mousePos.x = mousePos.x > 15.5f ? 15.5f : mousePos.x;
        mousePos.x = mousePos.x < 1.3f ? 1.3f : mousePos.x;
        player1.position = Vector2.MoveTowards (player1.position, new Vector2 (mousePos.x, player1.position.y), speed* Time.deltaTime);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) { // срабатвает когда сталкивается марковка с крликом
        if (other.tag.Equals("Rabbit")){ // ищем морковку по тегу, что это она 
            colcarrot.carrotCount += 1; // ведем счет, то есть записываем в счетчки 
            Destroy (other.gameObject); // удаляем объект как только он столкнеться
        }
    }
}
