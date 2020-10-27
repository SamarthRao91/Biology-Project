using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    public string Goto;
void OnCollisionEnter2D(Collision2D collision)
   {
       if(collision.gameObject.tag == "enemy")
       {
           
           Destroy(gameObject);
            SceneManager.LoadScene(Goto);
        }
   }   }
