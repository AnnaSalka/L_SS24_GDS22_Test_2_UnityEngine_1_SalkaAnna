using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneScreenScript : MonoBehaviour
{


    public GameObject doneScreen;
    public bool isDoneScreen = false;



    // Start is called before the first frame update
    void Start()
    {
        doneScreen.SetActive(false);   
        isDoneScreen = false;
    }


    void Update()
    {
        // Anzeige des Done-screens
        if (isDoneScreen!)
        {
            doneScreen.SetActive(false);
        }
        //nur wewnn alle 4 Bools true sind
        if (PuzzleLogicScript.L_Down && PuzzleLogicScript.L_Up && PuzzleLogicScript.R_Down && PuzzleLogicScript.R_Up)
        {
            doneScreen.SetActive(true);
            isDoneScreen = true;
            print("done");
        }
        
    }
}
