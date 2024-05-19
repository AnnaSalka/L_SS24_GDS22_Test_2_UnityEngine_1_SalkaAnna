using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trump"))
        {
            Debug.Log("trump");
            other.gameObject.GetComponent<Animator>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

}
