using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.Events;

namespace WorkFudger
{

    public class Throw : MonoBehaviour
    {
        public float speed = 0.02f;
        public float yinitial = 0;
        public float ycurr = 0;
        float ycurrent = 0;
        public bool thrown = false;
        public GameObject player;
        bool updateY = false;
        private bool returnPls = false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            ycurr = gameObject.transform.position.y;
            //  transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z), Time.deltaTime * 40); //Return To Player
            
           

            if (GetComponent<Interactable>().attachedToHand == null)
            {

                while(thrown == true)
                {
                    Vector3 vDirection = player.transform.position - transform.position;
                    if (vDirection.magnitude > 10)
                    {
                        returnPls = true;
                    }
                    if(returnPls == true)
                    {
                        ReturntoPlayer();
                    }
                }
               
            }
        }

        public void ReturntoPlayer()
        {
            //yinitial = gameObject.transform.position.y;
            Vector3 vDirection = player.transform.position - transform.position;
            
            while (vDirection.magnitude > 1)
            {

                // transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z), Time.deltaTime * 40); //Return To Player
                vDirection = player.transform.position - transform.position;
                vDirection.Normalize();

                transform.position += vDirection * speed;
            }
            thrown = false;
            returnPls = false;
        }
    }
}


