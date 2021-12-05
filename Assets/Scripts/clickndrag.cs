using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickndrag : MonoBehaviour
{
    public bool IsBeingDragged;

    void OnMouseDown()
    {
        Debug.Log("clicked!");
        IsBeingDragged = true;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsBeingDragged)
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position += Vector3.back*transform.position.z;
    }
    }
    void OnMouseUp()
    {
        IsBeingDragged = false;

    }
}
