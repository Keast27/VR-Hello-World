using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlass : MonoBehaviour
{
    //particle system
    private ParticleSystem wineParticles;

    // Start is called before the first frame update
    void Start()
    {
        wineParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if the up vector of this object has a negative y component
        if(transform.up.y < 0 && wineParticles.isPlaying != true)
        {
            //spill the drink and decrease date happiness
            wineParticles.Play();

            //decrease date happiness
            GameObject.FindGameObjectWithTag("Date").GetComponent<DateHappiness>().DecreaseHappiness(1);
        }
        else if(transform.up.y > 0 && wineParticles.isPlaying == true)
        {
            //stop the wine
            wineParticles.Stop();
        }
    }
}
