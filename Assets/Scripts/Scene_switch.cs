using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_switch : MonoBehaviour
{
    // Start is called before the first frame update
	public string Scene_Name = "";

	// Use this for initialization
	void Start () {
         
		Button b = GetComponent<Button> ();
		if (b != null && Scene_Name != "")
		{
			b.onClick.AddListener(() => {SceneManager.LoadScene(Scene_Name);});
		}
	}
	

}

