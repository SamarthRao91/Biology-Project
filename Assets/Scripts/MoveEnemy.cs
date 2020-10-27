using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rbEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
         rbEnemy.velocity = -transform.up * speed;
       
            
    }
}
