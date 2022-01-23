using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public float distheaven;
    Vector2 hellposition = new Vector2(0.0f,0.0f);
    Vector2 heavenposition = new Vector2(0.0f, 0.0f);
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("lol");
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        Debug.Log("Getting Position of Hell Player");
        hellposition = GameObject.Find("Hell").transform.position;
        Debug.Log("Getting Position of Heaven Player");
        heavenposition = transform.position;
        Debug.Log("Hell " + hellposition);
        Debug.Log("Heaven " + heavenposition);
    }

    // Update is called once per frame
    void Update()
    {
        hellposition = GameObject.Find("Hell").transform.position;
        Debug.Log("Hell Position: " + hellposition);
        heavenposition = transform.position;
        Debug.Log("HeavenPosition: " + heavenposition);
        float distheaven = Vector2.Distance(hellposition, heavenposition);
        Debug.Log(distheaven);
        if (distheaven > 0)
        {
            TakeDamage(1);
            Debug.Log("Damage Taken");
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
