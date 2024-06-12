using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static int coinCount = 0;
    public TextMeshProUGUI coinText;

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins : " + coinCount.ToString();
    }
}
