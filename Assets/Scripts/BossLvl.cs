using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossLvl : MonoBehaviour
{
    public GameObject player;
    EnemyHealth enemyHealthScript;
    public GameObject Enemy;
    public GameObject EnemyUI;
    public GameObject MainPanel;
    public Slider enemySlider;
    public Slider playerSlider;
    PlayerHealth playerHealth;
    bool isDead = false;

    private void Start()
    {
        enemyHealthScript = Enemy.GetComponent<EnemyHealth>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " , " + other.tag);
        Debug.Log("Platform3 Entered");
        if (other.CompareTag("Platform3"))
        {

            Enemy.SetActive(true);
            MainPanel.SetActive(false);
            EnemyUI.SetActive(true);
        }
    }
    private void Update()
    {
        Debug.Log(enemyHealthScript.currentEnemyHealth);
        enemySlider.value = enemyHealthScript.currentEnemyHealth;
        playerSlider.value = playerHealth.currentHealthplayer;
    }
}
