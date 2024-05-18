using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trump_spawn_script : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPoint;
    [SerializeField] private Vector3 finishPoint;
    [SerializeField] private float distance;
    [SerializeField] private bool isNull = false;
 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isNull == false)
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
        else
        {
            gameObject.transform.position = spawnPoint;
            isNull = false;
        }
        
    }
}
