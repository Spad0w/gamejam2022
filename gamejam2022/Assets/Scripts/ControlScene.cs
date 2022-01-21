using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if any key is pressed jump to gameplay
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("samplescene");
        }
    }
}
