using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{


    int CHP = 100;
  public  int MHP = 100;
    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
            takeDamage(12);
        

        
    }


   internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("Ouch you hurt my health is now" + CHP);
    }

    internal int whatsYourMaxhealth()
    {
        return MHP;
    }
}

