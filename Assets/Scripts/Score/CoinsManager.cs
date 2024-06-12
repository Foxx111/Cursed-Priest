using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource m_AudioSource;
    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag + "Coin");
        if (other.CompareTag("Player1"))
        {
            Debug.Log("Collided with player");
            m_AudioSource.Play();
            CoinCounter.coinCount += 10;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Destroy(gameObject);
        }
    }
}
