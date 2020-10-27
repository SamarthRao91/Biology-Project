using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
      public GameObject enemyPrefab;
      public Transform spawnLocation;
     public float randomX;
      public float timerValue = 1.5f;
      public float timerReset;
    
    // Start is called before the first frame update
    void Start()
    {
          timerReset = timerValue;
    }
    //x < 8.56   , x>-8.77
    // Update is called once per frame
    void Update()
    {  
         
         timerValue -= Time.deltaTime;
    if(timerValue <= 0)
    {
         
         Instantiate(enemyPrefab, spawnLocation.position, spawnLocation.rotation);
         timerValue = timerReset;
    }
    }
}
