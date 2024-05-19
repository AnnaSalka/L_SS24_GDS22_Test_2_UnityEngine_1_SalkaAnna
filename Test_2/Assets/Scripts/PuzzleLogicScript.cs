using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLogicScript : MonoBehaviour
{
    [SerializeField] private Vector3 origPosition;
    [SerializeField] private Vector3 newPosition;
    [SerializeField] private Vector3 maxDistance;

    private Vector3 origPosition_l_up;
    private Vector3 origPosition_l_down;
    private Vector3 origPosition_r_up;
    private Vector3 origPosition_r_down;

    [SerializeField] private GameObject apple_L_Up;
    [SerializeField] private GameObject apple_L_Down;
    [SerializeField] private GameObject apple_R_Up;
    [SerializeField] private GameObject apple_R_Down;

    [SerializeField] private float distApple_l_up;
    [SerializeField] private float distApple_l_down;
    [SerializeField] private float distApple_r_up;
    [SerializeField] private float distApple_r_down;

    static public bool L_Up = false;
    static public bool L_Down = false;
    static public bool R_Up = false;
    static public bool R_Down = false;

    [SerializeField] private GameObject indicator1;
    [SerializeField] private GameObject indicator2;
    [SerializeField] private GameObject indicator3;
    [SerializeField] private GameObject indicator4;

    // Start is called before the first frame update
    void Start()
    {
         L_Up = false;
         L_Down = false;
         R_Up = false;
         R_Down = false;
        SavePosition();   
        RandomPosition();  
        
    }

    // Update is called once per frame
    void Update()
    {
       
        distApple_l_down = Vector3.Distance(origPosition_l_down, apple_L_Down.transform.position);
        if (distApple_l_down <= 0.3f)
        {
            apple_L_Down.transform.position = origPosition_l_down;
            L_Down = true;
            indicator1.SetActive(true);
            print("links unten");
            
        }

        distApple_l_up = Vector3.Distance(origPosition_l_up, apple_L_Up.transform.position);
        if (distApple_l_up <= 0.3f)
        {
            apple_L_Up.transform.position = origPosition_l_up;
            L_Up = true;
            indicator2.SetActive(true);
            print("links oben");
            
        }

        distApple_r_down = Vector3.Distance(origPosition_r_down, apple_R_Down.transform.position);
        if (distApple_r_down <= 0.3f)
        {
            apple_R_Down.transform.position = origPosition_r_down;
            R_Down = true;
            indicator3.SetActive(true);
            print("rechts unten");
            
        }

        distApple_r_up = Vector3.Distance(origPosition_r_up, apple_R_Up.transform.position);
        if (distApple_r_up <= 0.3f)
        {
            apple_R_Up.transform.position = origPosition_r_up;
            R_Up = true;
            indicator4.SetActive(true);
            print("rechts oben");
            
        }

    }

    private void RandomPosition()
    {
        apple_L_Up.transform.position = new Vector3(Random.Range(7f, -7f), Random.Range(4f, -2.5f), 0);
        apple_L_Down.transform.position = new Vector3(Random.Range(7f, -7f), Random.Range(4f, -2.5f), 0);
        apple_R_Up.transform.position = new Vector3(Random.Range(7f, -7f), Random.Range(4f, -2.5f), 0);
        apple_R_Down.transform.position = new Vector3(Random.Range(7f, -7f), Random.Range(4f, -2.5f), 0);

    }

    private void SavePosition()
    {
        origPosition_l_down = apple_L_Down.transform.position;
        origPosition_l_up = apple_L_Up.transform.position;
        origPosition_r_down = apple_R_Down.transform.position;
        origPosition_r_up = apple_R_Up.transform.position;
    }

}

