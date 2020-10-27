using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
  
Transform m_transform;
public int playerSpeed = 5;
public string goTO;

    // Start is called before the first frame update
    void Start()
    {
         m_transform = gameObject.GetComponent<Transform>();
        


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            m_transform.position += new Vector3(-3 * Time.deltaTime,0,0);

        }
        else if(Input.GetKey(KeyCode.D))
        {
            m_transform.position += new Vector3(3 * Time.deltaTime,0,0);

        }
        if(Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(goTO);
            PlayerPrefs.DeleteAll();
        }
        
    }
}

