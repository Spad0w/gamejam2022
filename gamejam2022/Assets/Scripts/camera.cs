using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        float moverCamX = 0.003F;
=======
        float moverCamX = 0.002F;
>>>>>>> 250b28e7ffcb9435a262fc53c000f887e09c2fe6
        Camera.main.transform.Translate(moverCamX, 0, 0);
        
    }
}
