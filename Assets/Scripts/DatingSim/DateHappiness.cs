using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Happiness
{
    Angry,
    Neutral,
    Happy
}


public class DateHappiness : MonoBehaviour
{
    //current happiness values
    private int currentHappiness = 5;
    private Happiness currentState = Happiness.Neutral;

    //materials
    public List<Material> materials;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check happiness levels
        if(currentHappiness <= 3 && currentState != Happiness.Angry)
        {
            //change material and current state
            GetComponent<MeshRenderer>().material = materials[0];
            currentState = Happiness.Angry;
        }
        else if(currentHappiness >= 7 && currentState != Happiness.Happy)
        {
            //change material and current state
            GetComponent<MeshRenderer>().material = materials[1];
            currentState = Happiness.Happy;
        }
        else if(currentHappiness > 3 && currentHappiness < 7 && currentState != Happiness.Neutral)
        {
            //change material and current state
            GetComponent<MeshRenderer>().material = materials[2];
            currentState = Happiness.Neutral;
        }

        //don't let happiness go below zero or above ten
        if(currentHappiness < 0)
        {
            currentHappiness = 0;
        }
        else if(currentHappiness > 10)
        {
            currentHappiness = 10;
        }
    }

    public void DecreaseHappiness(int decrement)
    {
        currentHappiness -= decrement;
    }

    public void IncreaseHappiness(int increment)
    {
        currentHappiness += increment;
    }
}
