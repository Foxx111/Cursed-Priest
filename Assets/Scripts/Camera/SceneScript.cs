using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject Scene1;
    public GameObject Scene2;
    public Camera cam2;
    public PlayerHealth playerHealth;
    public GameObject Victory;
    bool isVictory = false;


  
    private void Update()
    {
        if(SceneSet.isBossDead == true && !isVictory)
        {
            Victory.SetActive(true);
        }
    }

    public static void PlayerDied()
    {
        
    }
    public void OnClick()
    {

        Debug.Log("Clicked");
        panel.SetActive(false);
        Scene1.SetActive(true);
        Scene2.SetActive(true);
        panel2.SetActive(true);
        cam2.enabled = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Clicked");
        panel.SetActive(false);
        Scene1.SetActive(true);
        Scene2.SetActive(true);
        panel2.SetActive(true);
        cam2.enabled = false;
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
