using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandFuctions : MonoBehaviour
{
    //Create my enginer variable
    int myInt = 5;



    // Start is called before the first frame update
    void Start()
    {
        //run my variable thru my fuction
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Create the multiply by two fuction
    int MultiplyByTwo(int number)
    {
        //Create a local variable 
        int result;
        result = number * 2;
        return result;


    }


}