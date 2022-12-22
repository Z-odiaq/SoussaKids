using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    void Start()
    {
        string text = save_load.Load();
        if (text.Contains("4"))
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
