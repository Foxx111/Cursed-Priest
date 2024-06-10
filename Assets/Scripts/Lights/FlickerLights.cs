using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour
{
    // Start is called before the first frame update
    public Light pointLight;
    public Light spotLight;

    float minIntensity = 0f;
    float maxIntensity = 2f;
    float flicker = 0.2f;

    float targetIntensity;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= flicker)
        {
            targetIntensity = Random.Range(minIntensity, maxIntensity);
            //Debug.Log(targetIntensity);
            timer = 0f;
        }
        spotLight.intensity = targetIntensity;
        pointLight.intensity = targetIntensity;
    }
}
