using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ContinueOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public string Goto;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(Goto);
    }
}
