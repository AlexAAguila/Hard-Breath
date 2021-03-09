using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    //variables
    private AudioSource sound;
    public GameObject player;
    private ParticleSystem fire, fire2, fire3;
    private int switchCheck=0;

     //start function to find gameobject and its component
    void Start()
    {

        sound = GetComponent<AudioSource>();
         player = GameObject.Find("FPSController");
         fire = GameObject.Find("fire").GetComponent<ParticleSystem>();
         fire2 = GameObject.Find("fire2").GetComponent<ParticleSystem>();
         fire3 = GameObject.Find("fire3").GetComponent<ParticleSystem>();
         //stop the particles playing
         fire.Stop();
         fire2.Stop();
         fire3.Stop();
    }

    // on mouse down function to see if the player clicked or not
    void OnMouseDown(){
        //check if the player is in range or not
if ((player.transform.position - this.transform.position).sqrMagnitude < 3*3 ){
    //switchcheck to count the state 
    switchCheck+=1;
    //if switchcheck is even it will play the sound effect and particles
    if(switchCheck %2==0){
sound.PlayOneShot(sound.clip);
    fire.Play();
    fire2.Play();
    fire3.Play();
    //if false it will stop the particles and the sound
    }else{
       sound.Stop();
    fire.Stop(); 
    fire2.Stop(); 
    fire3.Stop(); 
    }
    

    }
    }
}
