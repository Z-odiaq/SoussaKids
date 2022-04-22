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
    public Vector2 endPos;
    // public new Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        // lineRenderer = GetComponent<LineRenderer>();
        // endPoint = GetComponent<GameObject>();
        // collider = GetComponent<Collider2D>();
        // canvas = GetComponent<Canvas>();
        Debug.Log("started");
        //  canvas.renderMode = RenderMode.WorldSpace;

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
        Debug.Log("k");

        isDrawing = false;
        endPos.x = lineRenderer.GetPosition(1).x;
        endPos.y = lineRenderer.GetPosition(1).y;
        if (endPoint.GetComponent<Collider2D>().bounds.ClosestPoint(lineRenderer.GetPosition(1)) == lineRenderer.GetPosition(1))
        {
            Debug.Log("yess");
            lineRenderer.SetPosition(1, endPoint.transform.position);

        }
        else
        {
            Debug.Log("no: "+ endPoint.GetComponent<Collider2D>().bounds );
            lineRenderer.SetPosition(1, gameObject.transform.position);

        }
    }
}
