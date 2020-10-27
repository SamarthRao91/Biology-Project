using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PowerUps : MonoBehaviour
{  

    public Text questionText;
    public InputField textField;
    string answerInput = "";
    public string goTo;

    [HideInInspector]
    public string answer = "";
    [HideInInspector]
    public bool correctAnswer = false;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Correct", correctAnswer ? 1 : 0);

        string question = "";

        int randomX= Random.Range(1, 5);
        if (randomX == 1)
        {
            question = "What is the monomer of a protien";
            answer = "Amino Acid";
        }
        if (randomX == 2)
        {
            question = "What does ATP stand for";
            answer = "Adenosine triphosphate";
        }
        if (randomX == 3)
        {
            question = "What macromolecule holds genitic codes in your body";
            answer = "DNA";
        }
        if (randomX == 4)
        {
            question = "What is the monomer of a nucleic acid";
            answer = "nucleotides";
        }
        Debug.Log(question);
        questionText.text = question;
        
    }



    public void Submit()
    {
        answerInput = textField.text;
        if(answerInput == answer)
        {
            correctAnswer = true;
          
            PlayerPrefs.SetInt("correctAnswer", (correctAnswer ? 1 : 0));
            SceneManager.LoadScene(goTo);
        }
    }

   
}
