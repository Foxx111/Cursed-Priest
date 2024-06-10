using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour
{
    // Start is called before the first frame update
    float healthAmt = 100f;
    public GameObject healthOrb;
    public PlayerHealth healthScript;
    bool playerCollided = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerCollided == false)
        {
            playerCollided=true;
            Debug.Log("Collision occured");
            healthScript.currentHealth += 100;
            Debug.Log(healthScript.currentHealth);
            Destroy(healthOrb, 2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(healthScript.currentHealth);
        }
    }


}
