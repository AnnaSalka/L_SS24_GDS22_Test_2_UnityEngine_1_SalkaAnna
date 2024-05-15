using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Color col;

    private bool isMouseDown = false;

    void Update()
    {        
        if (isMouseDown)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            { 
                //Rotation wird getriggert nur wenn linke UND rechte Maustasten gedrükt sind
                RotateByDegrees();               
            }
        }
    }

    private Vector3 GetMousePos()
    {
        print("calculate now");
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        col = GetComponent<MeshRenderer>().material.color;
        GetComponent<MeshRenderer>().material.color = Color.yellow;
        GetComponent<Rigidbody>().isKinematic = true;

        isMouseDown = true;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    private void OnMouseUp()
    {
        GetComponent<MeshRenderer>().material.color = col;
        GetComponent<Rigidbody>().isKinematic = false;
        isMouseDown= false;

        
    }

    //rotiert die Objekte nach 45 Grad
    private void RotateByDegrees()
    {   
        Vector3 rotationToAdd = new Vector3(0, 0, 45);
        transform.Rotate(rotationToAdd);
       
    }
}