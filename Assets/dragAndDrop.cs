
using System.Collections;
using UnityEngine;

class dragAndDrop : MonoBehaviour
{
    private bool dragging = false;
    private float distance;

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Start()
    {
        Debug.Log(Camera.main.transform.position);
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            Vector3 temp = new Vector3(rayPoint.x, transform.position.y, transform.position.z);
            transform.position = temp;
        }
    }
}