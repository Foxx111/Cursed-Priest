using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    public int currentPlatform = -1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Platform1")
        {
            currentPlatform = 1;
        }
        else if(other.tag == "Platform2")
        {
            currentPlatform = 2;
        }
        else if(other.tag == "Platform3")
        {
            currentPlatform = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Platform1")
        {
            currentPlatform = 0;
        }
        else if (other.tag == "Platform2")
        {
            currentPlatform = 0;
        }
        else if (other.tag == "Platform3")
        {
            currentPlatform = 0;
        }
    }
    private void Update()
    {
        //Debug.Log(currentPlatform);
    }
}
