//drag camera with mouse
using UnityEngine;
using System.Collections;

public class Camera_Dragger : MonoBehaviour
{
    private Vector3 lastPosition;
    private bool bIsPressed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            bIsPressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            bIsPressed = false;
        }
        else if (bIsPressed)
        {
            Vector3 curMove = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) - lastPosition;

            Camera.main.transform.position -= curMove;

            lastPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
        {
            Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize - 100, 200);

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
        {
            Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize + 100, 1500);
        }
    }
}