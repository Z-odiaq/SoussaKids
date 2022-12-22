using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word_locker : MonoBehaviour
{

    //     Nada Mechi
    // 1-Yazid Ibn Hatim al-muhallabi.
    // 2-la cour
    // 3-le premier étage
    // 4-unesco
    // 5-le ribat
    // 6-la tour-vigie
    // 7-le deuxième étage
    // 8-le porche d'entrée
    // 9-ziyadat allah I
    // 10-un vestibule
    // Start is called before the first frame update
    public List<GameObject> Unesco = new List<GameObject>(6);
    public List<GameObject> Yazid_Ibn_Hatim_al_muhallabi = new List<GameObject>(27);
    public List<GameObject> la_cour = new List<GameObject>(7);
    public List<GameObject> le_premier_étage = new List<GameObject>(17);
    public List<GameObject> ribat = new List<GameObject>(5);
    public List<GameObject> tour_vigie = new List<GameObject>(10);
    public List<GameObject> le_deuxième_étage = new List<GameObject>(17);
    public List<GameObject> le_porche_d_entrée = new List<GameObject>(18);
    public List<GameObject> ziyadat_allah_I = new List<GameObject>(15);
    public List<GameObject> un_vestibule = new List<GameObject>(12);

    private string UnescoStr = "Unesco";
    private string Yazid_Ibn_Hatim_al_muhallabiStr = "Yazid Ibn Hatim al-muhallabi";
    private string la_courStr = "la cour";
    private string le_premier_étageStr = "le premier étage";
    private string ribatStr = "le ribat";
    private string tour_vigieStr = "la tour-vigie";
    private string le_deuxième_étageStr = "le deuxième étage";
    private string le_porche_d_entréeStr = "le porche d'entrée";
    private string ziyadat_allah_IStr = "ziyadat allah I";
    private string un_vestibuleStr = "un vestibule";
    public string Hiden_Chars = " '-É";
    //make string array special chars
    int winn = 0;
    public GameObject winScreen;
    //put quate between quotes 

    void Start()
    {

        //clean all game objects text input
        clean(Unesco);
        clean(Yazid_Ibn_Hatim_al_muhallabi);
        clean(la_cour);
        clean(le_premier_étage);
        clean(ribat);
        clean(tour_vigie);
        clean(le_deuxième_étage);
        clean(le_porche_d_entrée);
        clean(ziyadat_allah_I);
        clean(un_vestibule);



    }

    // Update is called once per frame
    void Update()
    {
        if (check(Unesco, UnescoStr))
        {
            //make each input field read only
            foreach (GameObject go in Unesco)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(Yazid_Ibn_Hatim_al_muhallabi, Yazid_Ibn_Hatim_al_muhallabiStr))
        {
            //make each input field read only
            foreach (GameObject go in Yazid_Ibn_Hatim_al_muhallabi)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(la_cour, la_courStr))
        {
            //make each input field read only
            foreach (GameObject go in la_cour)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(le_premier_étage, le_premier_étageStr))
        {
            //make each input field read only
            foreach (GameObject go in le_premier_étage)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(ribat, ribatStr))
        {
            //make each input field read only
            foreach (GameObject go in ribat)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(tour_vigie, tour_vigieStr))
        {
            //make each input field read only
            foreach (GameObject go in tour_vigie)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(le_deuxième_étage, le_deuxième_étageStr))
        {
            //make each input field read only
            foreach (GameObject go in le_deuxième_étage)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(le_porche_d_entrée, le_porche_d_entréeStr))
        {
            //make each input field read only
            foreach (GameObject go in le_porche_d_entrée)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(ziyadat_allah_I, ziyadat_allah_IStr))
        {
            //make each input field read only
            foreach (GameObject go in ziyadat_allah_I)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }
        if (check(un_vestibule, un_vestibuleStr))
        {
            //make each input field read only
            foreach (GameObject go in un_vestibule)
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
                winn++;
            }
        }


        if (winn == 10)
        {
            winScreen.SetActive(true);
            this.enabled = false;
        }

    }

    bool check(List<GameObject> listLetters, string word)
    {
        string ob = "";
        foreach (GameObject go in listLetters)
        {
            ob += (go.GetComponentInChildren<InputField>().text.ToUpper());
        }
        return ob == word.ToUpper();

    }
    void clean(List<GameObject> listLetters)
    {
        foreach (GameObject go in listLetters)
        {
            if (!Hiden_Chars.Contains(go.GetComponentInChildren<InputField>().text))
            {
                go.GetComponentInChildren<InputField>().text = "";
            }
            else if (go.GetComponentInChildren<InputField>().text != "")
            {
                go.GetComponentInChildren<InputField>().readOnly = true;
                go.GetComponentInChildren<InputField>().image.color = Color.green;
            }
        }
    }
}
