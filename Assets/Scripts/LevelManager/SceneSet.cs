using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSet : MonoBehaviour
{
    int lvl = -1;
    GameObject gate1;
    GameObject gate2;
    bool gate1Destroyed = false;
    bool gate2Destroyed = false;
    public static bool lvl1Complete = false;
    public static bool lvl2Complete = false;
    public static bool lvl3Complete = false;
    public GameObject Boss;
    EnemyHealth enemyHealth;
    public static bool isBossDead = false;


    private void Start()
    {
        Boss = GameObject.FindGameObjectWithTag("Boss");
        enemyHealth = Boss.GetComponent<EnemyHealth>();
    }

    private void Update()
    {
        Debug.Log("Coins are: " + CoinCounter.coinCount);
        if (CoinCounter.coinCount < 250)
        {
            lvl = 1;
        }
        else if (CoinCounter.coinCount == 250 && gate1Destroyed == false)
        {
            Debug.Log("Started");
            gate1 = GameObject.FindGameObjectWithTag("Gate1");
            Destroy(gate1);
            gate1Destroyed = true;
            lvl1Complete = true;

        }
        else if (CoinCounter.coinCount > 250 && CoinCounter.coinCount < 500)
        {

        }
        else if (CoinCounter.coinCount == 500 && gate2Destroyed == false)
        {
            gate2 = GameObject.FindGameObjectWithTag("Gate2");
            Destroy(gate2);
            gate2Destroyed = true;  
            lvl2Complete = true;
        }
        else if (CoinCounter.coinCount > 500 && CoinCounter.coinCount < 640 && enemyHealth.currentEnemyHealth <= 0)
        {
            isBossDead = true;
        }
    }
}
