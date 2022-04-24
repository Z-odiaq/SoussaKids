using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchingGame : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public Vector2 mousePos;
    public bool isDrawing = false;
    public Camera cam;
    public GameObject endPoint;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDrawing)
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, gameObject.transform.position);
            lineRenderer.SetPosition(1, new Vector3(mousePos.x, mousePos.y, gameObject.transform.position.z));
        }

    }

    void OnMouseDown()
    {
        isDrawing = true;
    }
    void OnMouseUp()
    {
        isDrawing = false;
        if (endPoint.GetComponent<Collider2D>().bounds.ClosestPoint(lineRenderer.GetPosition(1)) == lineRenderer.GetPosition(1))
        {
            lineRenderer.SetPosition(1, endPoint.transform.position);
        }
        else
        {
            lineRenderer.SetPosition(1, gameObject.transform.position);
        }
    }
}
