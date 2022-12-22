using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class puzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> children = new List<GameObject>();
    public Texture2D texture;
    public int[] order;
    Transform[] ts;
    Transform[] ps;
    public bool bingo = false;
    public GameObject pieces;
    public GameObject successWindow, img;

    void Start()
    {
        System.Random rnd = new System.Random();
        order = Enumerable.Range(1, 9).OrderBy(r => rnd.Next()).ToArray();

        ts = gameObject.GetComponentsInChildren<Transform>();
        ps = pieces.GetComponentsInChildren<Transform>();

        for (int i = 1; i <= ts.Length - 1; i++)
        {
            children.Add(ts[i].gameObject);

            var rect = new Rect(0, 0, 0, 0);
            switch (order[i - 1])
            {
                case 1:
                    {
                        rect = new Rect(0, 0, 200, 200);
                        ts[i].name = "1";
                        break;
                    }
                case 2:
                    {
                        rect = new Rect(0, 200, 200, 200);
                        ts[i].name = "2";
                        break;
                    }
                case 3:
                    {
                        rect = new Rect(0, 400, 200, 200);
                        ts[i].name = "3";

                        break;
                    }
                case 4:
                    {
                        rect = new Rect(200, 0, 200, 200);
                        ts[i].name = "4";

                        break;
                    }
                case 5:
                    {
                        rect = new Rect(200, 200, 200, 200);
                        ts[i].name = "5";

                        break;
                    }
                case 6:
                    {
                        rect = new Rect(200, 400, 200, 200);
                        ts[i].name = "6";

                        break;
                    }
                case 7:
                    {
                        rect = new Rect(400, 0, 200, 200);
                        ts[i].name = "7";

                        break;
                    }
                case 8:
                    {
                        rect = new Rect(400, 200, 200, 200);
                        ts[i].name = "8";

                        break;
                    }
                case 9:
                    {
                        rect = new Rect(400, 400, 200, 200);
                        ts[i].name = "9";

                        break;
                    }


            }

            var sprite = Sprite.Create(texture, rect, Vector2.one * 0.5f, 16f, 0, SpriteMeshType.Tight);

            ts[i].GetComponent<Image>().sprite = sprite;

        }




    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= ts.Length - 1; i++)
        {
            ///!ts[i].GetComponent<Drag>().moved &&
            if (!ps[i].GetComponent<PuzzleSnap>().isCorrect)
            {
                bingo = false;
                break;
            }
            else
            {
                bingo = true;
            }

        }
        if (bingo)
        {
            successWindow.SetActive(true);
            img.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }
}
