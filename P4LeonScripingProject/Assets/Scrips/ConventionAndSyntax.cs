using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is there to tell me the x position of my object
        Debug.Log(transform.position);

        
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.y <= 5f)
        {

            Debug.Log("i'm about to hit the ground!"); 
        }

        
    }


}
