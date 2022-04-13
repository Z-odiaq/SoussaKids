using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    private float Origin;

    public float cameraMaxY = 38;
    public float cameraMinY = -50;
 
    private float Diference;
    private bool Drag = false;

    void Start()
    {

    }
    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {

            Diference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)).y - Camera.main.transform.position.y;
            if (Drag == false)
            {
                Drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            }
        }else
        {
            Drag = false;
        }
        if (Drag == true)
        {
            if (cameraMaxY < Origin - Diference)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, cameraMaxY, Camera.main.transform.position.z);
            }
            else if (cameraMinY > Origin - Diference)
            {

                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, cameraMinY, Camera.main.transform.position.z);
            }
            else
            {

                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Origin - Diference, Camera.main.transform.position.z);

            }
        }



    }
}