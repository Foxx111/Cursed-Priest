using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int enemyStartingHealth;
    public int currentEnemyHealth;
    Animator animator;
    EnemyMove enemyMove;
    bool isDead = false;

    private void Awake()
    {
        currentEnemyHealth = enemyStartingHealth;
        animator = GetComponent<Animator>();
        enemyMove = GetComponent<EnemyMove>();
    }

    private void Update()
    {
        //Debug.Log(currentEnemyHealth);
        if (currentEnemyHealth <= 0 && !isDead)
        {
            isDead = true;
            EnemyDeath();
            KillManager.killCount++;
        }
    }

    public void EnemyTakeDamage(int amt)
    {
        if (currentEnemyHealth > 0)
        {
            currentEnemyHealth -= amt;
        }
    }

    void EnemyDeath()
    {
        //ScoreManagerScript.score += 20;
        enemyMove.enabled = false;
        animator.SetTrigger("Dead");
        GetComponentInChildren<NavMeshAgent>().enabled = false;
        GetComponentInChildren<SphereCollider>().enabled = false;
        Destroy(gameObject, 0.1f);
    }
}
