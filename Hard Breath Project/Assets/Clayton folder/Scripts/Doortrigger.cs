using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    //variables
    Animator doorAnimator;
    ChestKey keyCollect;
    private AudioSource doorsound;
//start function to find gameobject and its component
    void Start(){
        doorAnimator = this.transform.parent.GetComponent<Animator>();
        keyCollect = GameObject.Find("rust_key").GetComponent<ChestKey>();
        doorsound = this.transform.parent.GetComponent<AudioSource>();
       doorsound.Stop();
    }
    //on trigger enter function to check if the player collide with the door
    void OnTriggerEnter(Collider other)
    {
        //check if the player has the key or not
       if(keyCollect.keyCollect == true){
           //door animation will be played
doorAnimator.SetBool("isOpen", true);
       
        //sound effect play
        doorsound.PlayOneShot(doorsound.clip);
       }
        
    }
//check if the player leaves the trigger area or not
    private void OnTriggerExit(Collider other)
    {
         //door closing animation
        doorAnimator.SetBool("isOpen", false);
      
        
    }
    
}
