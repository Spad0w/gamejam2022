using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CollisionCheckRight : MonoBehaviour
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
            Debug.Log("Hit Detected, Next Level");
            SceneManager.LoadScene("Stage 2");
        }
    }

    void Update()
    {
       
        
    }
}
