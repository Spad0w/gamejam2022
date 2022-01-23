using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeaven: MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float distbetween;
    Vector2 hellposition = new Vector2(0.0f,0.0f);
    Vector2 heavenposition = new Vector2(0.0f, 0.0f);
    public HealthBar healthBar;
    public int damage;

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //hellposition = GameObject.Find("Hell").transform.position;
        //heavenposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        hellposition = GameObject.Find("Hell").transform.position;
        heavenposition = transform.position;
        distbetween = Vector2.Distance(hellposition, heavenposition);
        if (distbetween > 4.1f)
        {
           TakeDamage(1);
        }
    }
}
