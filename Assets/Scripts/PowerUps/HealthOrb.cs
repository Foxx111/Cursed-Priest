using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour
{
    // Start is called before the first frame update
    float healthAmt = 100f;
    public GameObject healthOrb;
    GameObject player;
    PlayerHealth healthScript;
    bool playerCollided = false;
    AudioSource audioSource;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Gun");
        healthScript = player.GetComponent<PlayerHealth>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") && playerCollided == false)
        {
            playerCollided=true;
            Debug.Log("Collision occured");
            healthScript.currentHealthplayer += 100;
            Debug.Log(healthScript.currentHealthplayer);
            audioSource.Play();
            Destroy(healthOrb, 2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(healthScript.currentHealthplayer);
        }
    }


}
