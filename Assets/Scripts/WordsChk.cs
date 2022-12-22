using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WordsChk : MonoBehaviour
{
    public List<string> wordsList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (WordSearch.insertedWords.Count == 0)
        {
            foreach (KeyValuePair<string, bool> p in WordSearch.insertedWords)
            {
                wordsList.Add(p.Key);
            }
            //            Debug.Log(string.Join(" - ", wordsList) + " " + wordsList.Count + " " + WordSearch.insertedWords.Count);
            this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = string.Join(" - ", wordsList);
        }
        foreach (KeyValuePair<string, bool> p in WordSearch.insertedWords)
        {
            Transform[] ts = this.gameObject.transform.GetComponentsInChildren<Transform>();



        }
    }
}
