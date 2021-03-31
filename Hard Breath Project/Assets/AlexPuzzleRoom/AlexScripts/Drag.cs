using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    // Start is called before the first frame update
    //Reference: https://www.youtube.com/watch?v=Xv-c3-IOnM0&t
    //I didn't use all of his code, plus I changed conditions and set Inactive assests to Active when conditions were met

    public Transform player; // Reference to player
    public Transform playerCam;// Follows camera's position
    bool hasPlayer = false;// If player is in range
    bool beingCarried = false; //If the item is being carried


    public AudioSource pickup;

    void Start()
    {
        pickup = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true; //Player is in range and condition is met to pick up the item

        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetMouseButtonDown(0)) //If player is in range and the Left mouse key is pressed the player can pick up the item
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;//This causes the item to be the child of the player
            beingCarried = true;
            pickup.Play();
            
        }
        else if (beingCarried && Input.GetMouseButtonDown(1)) //If left mouse key is pressed while the item is being carried, then the item is dropped
        {
            beingCarried = false;
            hasPlayer = false;
            transform.parent = null;// The item is no longer a child of the player
            GetComponent<Rigidbody>().isKinematic = false;
            this.transform.GetChild(3).gameObject.SetActive(false);//Sets the bottle colour asset to inactive

        }




    }
}
