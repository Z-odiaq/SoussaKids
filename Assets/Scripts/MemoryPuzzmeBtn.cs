using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryPuzzmeBtn : MonoBehaviour
{
    // Start is called before the first frame update
    Button b;

    void Start()
    {
        b = GetComponent<Button>();
        Memory.currentWord = "";
        b.onClick.AddListener(() => check());

    }
    private void check()
    {

        //b.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
        StartCoroutine(FadeImage(false, b));
        //debug log sprite name 
        Debug.Log(Memory.currentWord + " " + b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1) + " first " + Memory.first?.name + " second " + Memory.second?.name);
        if (Memory.currentWord != "")
        {
            Memory.second = b.gameObject;
            //set button alpha to 0 
            if (Memory.currentWord == b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1))
            {
                Debug.Log("Correct");
                b.enabled = false;
                Memory.currentWord = "";
                Memory.second = null;
                Memory.first = null;
                Memory.winCheck += b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1);

            }
            else if (Memory.currentWord != b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1) && Memory.currentWord != "")
            {
                Debug.Log("Wrong");
                Memory.currentWord = "";
                //find game object with the same name as the sprite name
                GameObject g = GameObject.Find(b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1));
                Debug.Log("found" + g.name);
                StartCoroutine(FadeImage(true, Memory.second.GetComponent<Button>()));
                StartCoroutine(FadeImage(true, Memory.first.GetComponent<Button>()));
                Memory.second = null;
                Memory.first = null;
                //b.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0 * Time.deltaTime);

            }
            else
            {

                StartCoroutine(FadeImage(true, b));

                //b.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1 * Time.deltaTime);
            }

        }
        else
        {
            Memory.first = b.gameObject;

            Memory.currentWord = b.transform.GetChild(0).GetComponent<Image>().sprite.name.Substring(0, 1);
        }

    }
    IEnumerator FadeImage(bool fadeAway, Button b)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 2; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                b.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 2; i += Time.deltaTime)
            {
                // set color with i as alpha
                b.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
