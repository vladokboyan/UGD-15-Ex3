using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour {

    public int a;

	// Use this for initialization
	void Start ()
    {
        MyCompare();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void MyCompare()
    {
        if (a >= 0 && a <= 30)
        {
            print("F: " + a);
        }
        else if (a >= 31 && a <= 50)
        {
            print("E: " + a);
        }
        else if (a >= 51 && a <= 60)
        {
            print("D: " + a);
        }
        else if (a >= 61 && a <= 70)
        {
            print("C: " + a);
        }
        else if (a >= 71 && a <= 80)
        {
            print("B: " + a);
        }
        else if (a >= 81 && a <= 100)
        {
            print("A: " + a);
        }
        else
        {
            print("wrong number");
        }
    }    
}
