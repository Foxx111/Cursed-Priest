using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    GameObject Player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        agent.SetDestination(Player.transform.position);
    }
}
