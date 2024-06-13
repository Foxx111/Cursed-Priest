using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    int startingHealthPlayer = 100;
    public int currentHealthplayer;
    bool isDead = false;
    public GameObject player;
    Animator animator;
    float toggleImageTime = 1.5f;
    AudioSource playerAudioSource;
    EnemyAttack enemyAttack;
    bool damaged;
    public Slider healthSlider;
    public Image toggleHurtImage;
    public AudioClip deathPlayerSound;
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI killsText;
    public GameObject TheEnd;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        enemyAttack = new EnemyAttack();
        currentHealthplayer = startingHealthPlayer;
        playerAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(currentHealthplayer > 100)
        {
            currentHealthplayer = 100;
        }
        if (currentHealthplayer <= 0 && !isDead)
        {
            Death();
        }
        if (damaged)
        {
            toggleHurtImage.color = Color.red;
        }
        else
        {
            toggleHurtImage.color = Color.Lerp(toggleHurtImage.color, Color.clear, toggleImageTime * Time.deltaTime);
        }
        damaged = false;
        healthSlider.value = currentHealthplayer;
    }

    public void TakeDamage(int amt)
    {
        Debug.Log("taking damage");
        Debug.Log(currentHealthplayer);
        currentHealthplayer -= amt;
        //playerAudioSource.Play();
        damaged = true;
        if (currentHealthplayer <= 0)
        {
            //animator.SetTrigger("Die");
            Death();
        }
    }

    void Death()
    {
        //SceneScript.PlayerDied();
        toggleHurtImage.color = Color.clear;
        //Time.timeScale = 0;
        coinsText.text = "coins : " + CoinCounter.coinCount.ToString();
        killsText.text = "kills : " + KillManager.killCount.ToString();
        isDead = true;
        playerAudioSource.clip = deathPlayerSound;
        playerAudioSource.Play();
        TheEnd.SetActive(true);

    }
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        //ScoreManagerScript.score = 0;
    }
}
