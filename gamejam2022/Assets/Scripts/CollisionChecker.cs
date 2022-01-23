using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CollisionChecker : MonoBehaviour
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
        //Debug.Log(hellposition);
        //Debug.Log(heavenposition);
        float distance = Vector2.Distance(hellposition, heavenposition);
        Debug.Log(distance);
        if(distance > 4.0f)
        {
            GameObject.Find("Heaven").GetComponent<PlayerHeaven>().currentHealth -= 1;
            Debug.Log("Damage Taken by Heaven");
        }
        
    }
}
