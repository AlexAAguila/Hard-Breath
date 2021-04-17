using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour
{
    //variable
     public GameObject player;
    public bool keyCollect = false;

      //start function to find gameobject and its component
    void Start()
    {
        player = GameObject.Find("FPSController");
    }

    // Update function to destroy the key object if the user collide to it
    void Update()
    {
         if ((player.transform.position - this.transform.position).sqrMagnitude < 2*2){
             
             Destroy(gameObject);
            
            keyCollect = true;
            GameObject.FindWithTag("manager").GetComponent<s_Inventory>().bkey = true;
        }
   
    }
}
