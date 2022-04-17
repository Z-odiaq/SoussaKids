using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


[System.Serializable]
public class Settings
{
    public string lang;
    public int vol;

}

[System.Serializable]
public class SettingsG
{
    public Settings settings;

}

[System.Serializable]
public class Places
{
    public string place;
    public string info;
    public string puzzle;
    public PuzzleData puzzleData;

}


[System.Serializable]
public class PlacesList
{
    public Places[] placesFR;
    public Places[] placesEN;

}
[System.Serializable]

public class PuzzleData
{
    public string[] questions;
    public string[] answers;
}
public class star : MonoBehaviour
{
    public PlacesList placeslistFR = new PlacesList();
    public SettingsG settings = new SettingsG();

    public TextAsset jsonFile;


    // Start is called before the first frame update
    void Start()
    {

        placeslistFR = JsonUtility.FromJson<PlacesList>(jsonFile.text);
        settings = JsonUtility.FromJson<SettingsG>(jsonFile.text);

        //Debug.Log(placeslist.place);
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
