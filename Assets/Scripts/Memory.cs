using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memory : MonoBehaviour
{

    public static GameObject first;
    public static GameObject second;
    public GameObject WinScreen;

    public static string winCheck = "";
    public static string currentWord;
    public Sprite[] sprites = new Sprite[12];
    Button b;


    public GameObject[] buttons = new GameObject[12];
    // Start is called before the first frame update
    void Start()
    {

        int[] random = new int[12];

        //generate random numbers for the array of sprites 2,1,4,5,6,3
        for (int i = 0; i < 12; i++)
        {
            random[i] = Random.Range(0, 12);
            for (int j = 0; j < i; j++)
            {
                if (random[i] == random[j])
                {
                    i--;
                    break;
                }
            }
        }


        for (int i = 0; i < 12; i++)
        {
            buttons[random[i]].transform.GetChild(0).GetComponent<Image>().sprite = sprites[i];
            buttons[random[i]].name = sprites[i].name.Substring(0, 1);

        }

    }



    // Update is called once per frame
    void Update()
    {
        if (winCheck.Contains("0") && winCheck.Contains("1") && winCheck.Contains("2") && winCheck.Contains("3") && winCheck.Contains("4") && winCheck.Contains("5"))
        {
            string text = save_load.Load();
            save_load.Save(text + "4");
            WinScreen.SetActive(true);
        }
    }
}
