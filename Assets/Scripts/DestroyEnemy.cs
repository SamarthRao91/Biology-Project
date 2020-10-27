using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    public int score = 0;
   void OnCollisionEnter2D(Collision2D collision)
   {
       if(collision.gameObject.tag == "bullet")
       {
           Debug.Log("Candies");
           Destroy(gameObject);
            score++;
       }
   }
}
