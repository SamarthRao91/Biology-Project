using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnClickedDef : MonoBehaviour
{

    public string Goto;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(Goto);
        if (Input.GetKey(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}