using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trump_spawn_script : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPoint;
    [SerializeField] private Vector3 finishPoint;
    [SerializeField] private float distance;
    [SerializeField] private bool isNull = false;

    [SerializeField] private bool isShooted = false;
 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isShooted == false) //wenn dei Figur von den Apfel nicht getroffen ist...
        {
            if (isNull == false) //soll die Bewegung erstelltv sein
            {
                distance = Vector3.Distance(gameObject.transform.position, finishPoint);

                if (distance > 3)
                {
                    isNull = false;
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.05f, 0, 2);
                }
                else
                {

                    isNull = true;
                }
            }
            else //oder wen ziel erreicht ist, soll die Figur zum Startposotion respawnen
            {
                gameObject.transform.position = spawnPoint;
                isNull = false;
            }
        }
        

        //---------------------

        if (gameObject.GetComponent<Animator>().enabled == false)
        {
            isShooted = true;
        }
    }
}
