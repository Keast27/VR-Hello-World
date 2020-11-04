using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    //check if the table was flipped
    private bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.up.y <= 0 && flipped == false)
        {
            //instantly set date happiness to zero
            GameObject.FindGameObjectWithTag("Date").GetComponent<DateHappiness>().DecreaseHappiness(100);

            //set table as flipped 
            flipped = true;
        }
    }
}
