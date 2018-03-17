using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour {

    public float math;
    public float physics;
    public float ukrainian;

    // Use this for initialization
    void Start ()
    {
        MyCompare();	
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void MyCompare()
    {
        float sum = (math + physics + ukrainian) / 3;

        if (sum > 150)
        {
            print("your score " + sum + " Test passed");
        }
        else
            print("your score " + sum + " Test failed");
            
       
    } 

}
