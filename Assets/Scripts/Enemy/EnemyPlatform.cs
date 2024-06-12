using UnityEngine;

public class EnemyPlatform : MonoBehaviour
{
    public GameObject enemy;
    public int currentEnemyPlatform = -1;
    GameObject player;
    PlayerPlatform playerPlatform;
    bool stasgeCherck = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player1");
        playerPlatform = player.GetComponent<PlayerPlatform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemy: " + other.tag);
        if (other.tag == "Platform1")
        {
            currentEnemyPlatform = 1;
        }
        else if (other.tag == "Platform2")
        {
            currentEnemyPlatform = 2;
        }
        else if (other.tag == "Platform3")
        {
            currentEnemyPlatform = 3;
        }
        stasgeCherck = true;
    }

    private void Update()
    {
        //Debug.Log(playerPlatform.currentPlatform + " " + currentEnemyPlatform);
        if (stasgeCherck)
        {

            if (playerPlatform.currentPlatform == currentEnemyPlatform)
            {
                enemy.SetActive(true);
            }
            else
            {
                enemy.SetActive(false);
            }
        }
    }
}
