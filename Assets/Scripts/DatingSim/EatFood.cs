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
        //destroy it when you eat it
        //Destroy(other.gameObject);

        if (other.tag == "Food")
        {

            Debug.Log("Eating food");

            //destroy it when you eat it
            Destroy(other.gameObject);

            //TODO: check the type of food and change date happiness
        }
    }
}
