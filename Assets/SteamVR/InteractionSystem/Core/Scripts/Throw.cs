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
        private Rigidbody rb;
        private Vector3 vDirection;
        public float vMag;
        public float velocity;
        // Start is called before the first frame update
        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            rb = gameObject.GetComponent<Rigidbody>();          
            if (GetComponent<Interactable>().attachedToHand == null)
            {
                if(thrown == true)
                {
                   // rb.velocity += gameObject.transform.position * 5;
                    vDirection = player.transform.position - transform.position;
                    vMag = vDirection.magnitude;
                    vDirection.Normalize();
                    transform.position -= vDirection * speed;
                    if (vMag > 10)
                    {
                        /*
                        var opposite = -rb.velocity;
                        //rb.velocity = Vector3.zero;
                        rb.AddForce(opposite, ForceMode.VelocityChange);
                        */
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
            vMag = vDirection.magnitude;
            

            while (vMag > 1)
            {

                // transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z), Time.deltaTime * 40); //Return To Player
                vDirection = player.transform.position - transform.position;
                vMag = vDirection.magnitude;
                vDirection.Normalize();

                //rb.AddForce(vDirection, ForceMode.Force);

                transform.position += vDirection * speed;
            }
            vDirection = player.transform.position - transform.position;
            vMag = vDirection.magnitude;
            thrown = false;
            returnPls = false;
           
        }
    }
}


