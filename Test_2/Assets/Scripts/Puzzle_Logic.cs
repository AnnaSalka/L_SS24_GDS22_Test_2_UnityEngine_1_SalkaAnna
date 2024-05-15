using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle_Logic : MonoBehaviour
{
    //private Vector3 origPosition_l_up;
    //private Vector3 origPosition_l_down;
    //private Vector3 origPosition_r_up;
    //private Vector3 origPosition_r_down;

    //private GameObject apple_L_Up;
    //private GameObject apple_L_Down;
    //private GameObject apple_R_Up;
    //private GameObject apple_R_Down;

    [SerializeField] private Vector3 origPosition;
    [SerializeField] private Vector3 newPosition;
    [SerializeField] private Vector3 maxDistance;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        origPosition = gameObject.transform.position;
        print("origanale Position ist gespeichert");
        RandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
       

       if (newPosition == origPosition)
        {
            print($"right place for {gameObject.name}");
        }
       else
        {
            newPosition = gameObject.transform.position;
            maxDistance = newPosition - origPosition;    
            if (maxDistance.x <= 1f) 
            {
              print("x ist kleiner als 1");
              if (maxDistance.y <= 1f)
              { 
                    print("y ist kleiner als 1");
                    gameObject.transform.position = origPosition;
                    gameObject.GetComponent<DragAndDrop>().enabled = false;
                    gameObject.GetComponent<Rigidbody>().isKinematic = true;

              }
            }
        }

    }
    private void RandomPosition()
    {
        gameObject.transform.position = new Vector3(Random.Range(7f, -7f), Random.Range(4f, -2.5f), 0);
    }
}
