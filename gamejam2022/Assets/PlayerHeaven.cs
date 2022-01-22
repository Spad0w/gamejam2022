using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public float distheaven;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("lol");
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        distheaven = Vector2.Distance(Heaven,Hell);
        Debug.Log(distheaven);
        if (distheaven > 0)
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
