using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDriver : MonoBehaviour
{

    [SerializeField]
    private Camera cam;


    [SerializeField]
    private SpriteRenderer mapRenderer;
    private float mapMinX, mapMaxX, mapMinY, mapMaxY;
    private Vector3 dragOrigin;
    public GameObject[] Array;// create an array


    private void Awake()
    {
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
        {
            Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize - 100, 200);

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
        {
            Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize + 100, 1500);
        }
        // check if there are any GameObjects (with the specified tag) spawned
        PanCamera();


    }

    private void PanCamera()
    {

        if (Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
            //print("origin " + dragOrigin + " newPosition " + cam.ScreenToWorldPoint(Input.mousePosition) + " =difference" + difference);

            cam.transform.position = ClampCamera(cam.transform.position + difference);

        }


    }


    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }
}