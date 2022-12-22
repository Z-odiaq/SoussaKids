

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update

    // Use this for initialization
    void Start()
    {

        Button b = GetComponent<Button>();
        if (b != null)
        {
            b.onClick.AddListener(() => Application.Quit());
        }
    }


}

