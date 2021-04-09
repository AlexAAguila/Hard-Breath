using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this code allows for the user to pick up certain items and move them around
public class PickUp : MonoBehaviour
{

  //here i declare the variable of where the destination will be
  public Transform theDest;


//on this method we control what happens while the mouse is being clicked
  void OnMouseDown()
  {

    //this two parts disable the object properties so that it can be held by the player
    GetComponent<BoxCollider>().enabled = false;
    GetComponent<Rigidbody>().useGravity = false;

    //this parts here change the position of the object to that of the users "hands"
    this.transform.position = theDest.position;
    this.transform.parent= GameObject.Find("Destination").transform;
  }


//on this method we control what happens while the mouse is no longer clicked
  void OnMouseUp()
  {

    // here we basically just undo what we prevoisly did to return the attributes of
    //the objects to their original state
    this.transform.parent = null;
    GetComponent<Rigidbody>().useGravity = true;
    GetComponent<BoxCollider>().enabled = true;
  }
}
