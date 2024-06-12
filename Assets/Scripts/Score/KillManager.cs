using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillManager : MonoBehaviour
{
    public static int killCount = 0;
    public TextMeshProUGUI killCounter;
    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(killCount);
        killCounter.text = "Kills : "+ killCount.ToString();
    }
}
