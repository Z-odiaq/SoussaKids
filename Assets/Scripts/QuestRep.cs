using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestRep : MonoBehaviour
{
    // Start is called before the first frame update
    public Text question;
    public GameObject winScreen;

    int currentQuestion = 0;
    public Button bt1;
    public Button bt2;
    public Button bt3;



    string[] questions = new string[8] {
"Qui est le gouverneur qui a demandé la construction de la Grande Mosquée de :",
"La Grande Mosquée de Sousse fut érigée en : ",
"qui est l'émir aghlabide qui va agrandir la Grande mosquée de Sousse en  :",
"Quel est le nombre de travées composant la salle de prière de la grande mosquée de sousse :",
" Le mihrab de la salle de prière est daté pour sa part de l’époque :",
"la mosquée fut de nouveau restaurée sous le règne d’un autre prince qui est :",
"De combien de portiques la cour centrale de cette forteresse est entourée :",
"Le quatrième, à côté de la salle de prière, sur colonnes, fut rajouté sans doute à l'époque ziride, et fut rénové à l'époque :"};

    int[] ansArr = new int[8] { 0, 2, 2, 2, 1, 1, 2, 0 };
    public GameObject faux;
    public GameObject vrais;

    int fauxCounte = 0;
    int vraisCounte = 0;

    string[] answers1 = new string[3] { "Abou Al-Abbas Mohamed", "Yazid Ibn Hatim AL-muhallabi", "Ziyadat Allah Ier" };
    string[] answers2 = new string[3] { "270 H/ 883 après J.-C", "247 H /862 après J.-C", "236 H/851 après J.-C" };
    string[] answers3 = new string[3] { "Abou al-Abbas Mohamed", "Okba Ibn Nafaa", "Ziyadat Allah Ier" };
    string[] answers4 = new string[3] { "Trois travées", "Neufs travées", "Six travées" };
    string[] answers5 = new string[3] { "Fatimide", "Abasside", "Ziride" };
    string[] answers6 = new string[3] { "Yazid Ibn Hatim al-Muhallabi", "Ibrahim II", "Khalaf al-Fata" };
    string[] answers7 = new string[3] { "Trois portiques", "Deux portiques", "Quatre portiques" };
    string[] answers8 = new string[3] { "Mouradite", "Husseinite", "Aghlabide" };



    void Start()
    {

        bt1.GetComponentInChildren<Text>().text = answers1[0];
        bt2.GetComponentInChildren<Text>().text = answers1[1];
        bt3.GetComponentInChildren<Text>().text = answers1[2];


        bt1.onClick.AddListener(() => check(0));


        bt2.onClick.AddListener(() => check(1));


        bt3.onClick.AddListener(() => check(2));

    }

    // Update is called once per frame
    void Update()
    {

        if (currentQuestion == 8)
        {
            winScreen.SetActive(true);
        }
        else
        {
            question.GetComponent<Text>().text = questions[currentQuestion];

        }



        if (currentQuestion == 0)
        {
            bt1.GetComponentInChildren<Text>().text = answers1[0];
            bt2.GetComponentInChildren<Text>().text = answers1[1];
            bt3.GetComponentInChildren<Text>().text = answers1[2];
        }
        else if (currentQuestion == 1)
        {
            bt1.GetComponentInChildren<Text>().text = answers2[0];
            bt2.GetComponentInChildren<Text>().text = answers2[1];
            bt3.GetComponentInChildren<Text>().text = answers2[2];
        }
        else if (currentQuestion == 2)
        {
            bt1.GetComponentInChildren<Text>().text = answers3[0];
            bt2.GetComponentInChildren<Text>().text = answers3[1];
            bt3.GetComponentInChildren<Text>().text = answers3[2];
        }
        else if (currentQuestion == 3)
        {
            bt1.GetComponentInChildren<Text>().text = answers4[0];
            bt2.GetComponentInChildren<Text>().text = answers4[1];
            bt3.GetComponentInChildren<Text>().text = answers4[2];
        }
        else if (currentQuestion == 4)
        {
            bt1.GetComponentInChildren<Text>().text = answers5[0];
            bt2.GetComponentInChildren<Text>().text = answers5[1];
            bt3.GetComponentInChildren<Text>().text = answers5[2];
        }
        else if (currentQuestion == 5)
        {
            bt1.GetComponentInChildren<Text>().text = answers6[0];
            bt2.GetComponentInChildren<Text>().text = answers6[1];
            bt3.GetComponentInChildren<Text>().text = answers6[2];
        }
        else if (currentQuestion == 6)
        {
            bt1.GetComponentInChildren<Text>().text = answers7[0];
            bt2.GetComponentInChildren<Text>().text = answers7[1];
            bt3.GetComponentInChildren<Text>().text = answers7[2];
        }
        else if (currentQuestion == 7)
        {
            bt1.GetComponentInChildren<Text>().text = answers8[0];
            bt2.GetComponentInChildren<Text>().text = answers8[1];
            bt3.GetComponentInChildren<Text>().text = answers8[2];
        }

        vrais.GetComponent<Text>().text = vraisCounte.ToString();
        faux.GetComponent<Text>().text = fauxCounte.ToString();



    }
    void check(int a)
    {
        if (ansArr[currentQuestion] == a)
        {
            vraisCounte++;
            Debug.Log("vrais");
        }
        else
        {
            fauxCounte++;
            Debug.Log("faux");
        }
        currentQuestion++;

    }


}
