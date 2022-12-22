using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterCheck : MonoBehaviour
{

    //textinput 
    public string letter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //compare the letter to the text child component
        if (this.gameObject.GetComponentInChildren<InputField>().text.ToUpper() == letter.ToUpper())
        {
            //change background color to green
            this.gameObject.GetComponent<InputField>().image.color = Color.green;
            Debug.Log("Correct " + this.gameObject.GetComponentInChildren<InputField>().text.ToUpper());
        }
        else
        {
            this.gameObject.GetComponent<InputField>().image.color = Color.white;
            Debug.Log("Incorrect " + this.gameObject.GetComponentInChildren<InputField>().text.ToUpper());

        }
        //get child text component and compare it to the letter in the word 

        //if it is the same letter, then change the color of the background
        //if it is not the same letter, then change the color of the background

    }
}
