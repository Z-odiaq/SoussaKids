using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


[System.Serializable]
public class jdata
{
    public string place;
    public string info;
    public string puzzle;
    public string puzzleData;

}
public class star : MonoBehaviour
{

    public string PlaceID = "";
    public string title = "";
    public string desc = "";
    public TextAsset jsonFile;


    // Start is called before the first frame update
    void Start()
    {

        jdata[] employeesInJson = JsonUtility.FromJson<jdata[]>(jsonFile.text);
        Debug.Log(employeesInJson[0].place);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");

        }
    }
}
