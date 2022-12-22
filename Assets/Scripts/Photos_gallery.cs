using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Outside your functions where you want to set all your declarations...


public class Photos_gallery : MonoBehaviour
{
    //At the very top...
    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible

    public int i = 0; //Will control where in the array you are
    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
        else
        {
            i = 0;
        }
        displayImage.sprite = gallery[i];
    }

    public void BtnPrev()
    {

        if (i - 1 > 0)
        {
            i--;
        }
        else
        {
            i = gallery.Length;
        }
        displayImage.sprite = gallery[i];
    }


    // Start is called before the first frame update

}
