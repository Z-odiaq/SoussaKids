using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


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
public class Place
{
    public string name;
    public string info;
    public string[] pictures;
    public string puzzle;
    public PuzzleData puzzleData;

}


[System.Serializable]
public class PlacesList
{
    public Place[] placesFR;
    public Place[] placesEN;
    public Place[] placesAR;

    public Place[] GetPlaces(string lang)
    {
        if (lang == "EN")
        {
            return placesEN;
        }
        else if (lang == "FR")
        {
            return placesFR;
        }
        else
        {
            return placesAR;
        }
    }

}
[System.Serializable]

public class PuzzleData
{
    public string[] questions;
    public string[] answers;
}
public class star : MonoBehaviour
{

    public PlacesList placeslists = new PlacesList();
    public SettingsG settings = new SettingsG();
    public string PlaceName = "";
    public GameObject placeControler;
    public GameObject placeDesc;
    public GameObject placetitle;
    public TextAsset jsonFile;
    public GameObject jgsawPuzzle;
    public GameObject matchingGame;
    public GameObject gameButton;
    public GameObject placeWindow;

    // Start is called before the first frame update
    void Start()
    {

            placeslists = JsonUtility.FromJson<PlacesList>(jsonFile.text);
            settings = JsonUtility.FromJson<SettingsG>(jsonFile.text);

    }

    // Update is called once per frame
    void Update()
    {
 
    }
    void OnMouseDown()
    {

        if (GameObject.FindGameObjectsWithTag("freezCam").Length ==0)
        {
            string lang = settings.settings.lang == "EN" ? "placesFR" : settings.settings.lang == "FR" ? "placesFR" : "placesAR";
            foreach (Place place in placeslists.GetPlaces(lang))
            {
                if (place.name.ToLower() == PlaceName.ToLower())
                {
                    Debug.Log(place.puzzle);
                    placeDesc.GetComponent<UnityEngine.UI.Text>().text = place.info;
                    placetitle.GetComponent<UnityEngine.UI.Text>().text = place.name;
                    if (place.puzzle == "1")
                    {
                        
                        gameButton.GetComponent<Button>().onClick.AddListener(() => { matchingGame.SetActive(true); placeWindow.SetActive(false); });
                    }
                    else if (place.puzzle == "2")
                    {
                       
                        gameButton.GetComponent<Button>().onClick.AddListener(() => { jgsawPuzzle.SetActive(true); placeWindow.SetActive(false); });

                    }

                }
                placeControler.SetActive(true);
            }
        }
    }
}
