using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
             if(!GetComponent<Renderer>().isVisible){
            Destroy(gameObject);
            }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
      Destroy(gameObject);
    }
}
