using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float timeBetweenAttacks = 1f;
    public int attackAmount;
    PlayerHealth playerHealth;
    GameObject player;
    public GameObject enemy;
    public bool playerIsInRange;
    float timer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Gun");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("entered");
            playerIsInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            Debug.Log("exited");
            playerIsInRange = false;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenAttacks && playerIsInRange && playerHealth.currentHealthplayer > 0)
        {
            timer = 0;
            Debug.Log("Inside Update");
            playerHealth.TakeDamage(attackAmount);
        }
    }
}
