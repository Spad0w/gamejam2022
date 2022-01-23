using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CollisionCheckLeft : MonoBehaviour
{
    public AudioSource noise;
    
    void Start()
    {
        noise = GetComponent<AudioSource>();
        //float distance = 0.0;   
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            noise.Play();
            Debug.Log("Sound Effect Played");
            Debug.Log("Hit Detected, Restarting Level");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Update()
    {
        var hellposition = GameObject.Find("Hell").transform.position;
        var heavenposition = GameObject.Find("Heaven").transform.position;
        float distance = Vector2.Distance(hellposition, heavenposition);
        if(distance > 4.1f)
        {
            GameObject.Find("Heaven").GetComponent<PlayerHeaven>().TakeDamage(1);
        }
        if (GameObject.Find("Heaven").GetComponent<PlayerHeaven>().currentHealth < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
