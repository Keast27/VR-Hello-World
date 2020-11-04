using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.GetComponent<FoodScript>() != null)
        {
            Debug.Log("Eating a food");

            //check the type of food and change date happiness
            if (other.transform.gameObject.GetComponent<FoodScript>().type == FoodType.Animal)
            {
                GameObject.FindGameObjectWithTag("Date").GetComponent<DateHappiness>().DecreaseHappiness(3);
            }
            else
            {
                GameObject.FindGameObjectWithTag("Date").GetComponent<DateHappiness>().IncreaseHappiness(3);
            }

            //destroy food when you eat it
            Destroy(other.gameObject);
        }
    }
}
