using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class matchGameArrow : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public Vector2 mousePos;
    public bool isDrawing = false;
    public Camera cam;
    public GameObject endPoint;
    public new Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        endPoint = GetComponent<GameObject>();
        collider = GetComponent<Collider2D>();
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
            lineRenderer.SetPosition(1, new Vector3(mousePos.x, mousePos.y, -5f));
           // CamDriver.dragging = false;

        }
        if (endPoint.GetComponent<Collider2D>().bounds.Contains(lineRenderer.GetPosition(1)))
        {
            Debug.Log("yess");

        }
        else
        {
            lineRenderer.SetPosition(1, gameObject.transform.position);

        }
        CamDriver.dragging = true;

    }

    void OnMouseDown()
    {
        isDrawing = true;
    }
    void OnMouseUp()
    {
        isDrawing = false;
    }
}
