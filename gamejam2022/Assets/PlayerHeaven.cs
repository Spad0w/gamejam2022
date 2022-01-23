using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public float distheaven;
    //public float hellposition;
    //public float heavenposition;
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
        var hellposition = GameObject.Find("Hell").transform.position;
        Debug.Log(hellposition);
        var heavenposition = transform.position;
        Debug.Log(heavenposition);
        distheaven = Vector2.Distance(hellposition, heavenposition);
        Debug.Log(distheaven);
        if (distheaven > 0)
        {
            TakeDamage(1);
            Debug.Log("Damage Taken");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
