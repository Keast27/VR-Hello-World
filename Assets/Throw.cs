using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Throw : MonoBehaviour
{
    float yinitial = 0;
    float ycurrent = 0;

    public GameObject player;
    bool updateY = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (updateY)
        {
            ycurrent = gameObject.transform.position.y;
        }

        if(GetComponent<Interactable>().attachedToHand == null)
        {
            ReturntoPlayer();
        }
    }

    public void ReturntoPlayer()
    {
        yinitial = gameObject.transform.position.y;
        ycurrent = yinitial;
        updateY = true;
        if(ycurrent < yinitial)
        {
            updateY = false;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z), Time.deltaTime * 40); //Return To Player
           //Woo
        }
     }
 }



