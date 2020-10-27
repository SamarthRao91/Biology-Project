using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform firePoint2;
    bool correct;

    void Start()
    {
        //correct = gameObject.GetComponent<PowerUps>().correctAnswer;
        correct = (PlayerPrefs.GetInt("correctAnswer") != 0);
     
    }
    // Update is called once per frame
    void Update()
    {

                                                             
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        Debug.Log(correct);
    }

    void Shoot()
    {
        //shooting code
        if(correct == false)
        {
      Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        if(correct == true)
        {
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
           Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            
        }
        PlayerPrefs.DeleteAll();

    }
}
