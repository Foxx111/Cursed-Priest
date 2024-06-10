using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody rb;
    public float startingHealth = 40;
    public float currentHealth;
    float maxHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth >= maxHealth) currentHealth = 100;
        Debug.Log(currentHealth);
    }
}
