using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour {

    int Health = 100;
    bool alive = true;
    // Use this for initialization
    void Start ()
    {
        HPDecrease();
    }
	
	// Update is called once per frame
	void Update ()
    {
        HPDecrease();
    }

    void HPDecrease()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            Health = Health - 10;
            print(Health);
        }
        else if (Health <= 20 && Health >= 0)
        {
            print("Low Health");

        }
        else if (Health <= 0)
        {
            alive = false;
            print("Mission Failed, Character is dead");
        }
    }
}
