using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{

    //variable
public GameObject player;
private int openCheck=1;
Animator wardrobeAnimator;
//start function to find gameobject and its component
    void Start(){
        wardrobeAnimator = gameObject.GetComponent<Animator>();
         player = GameObject.Find("FPSController");
    }
    // on mouse down function
    void OnMouseDown(){
        //check if the player clicked when he is near the wardrobe or not
if ((player.transform.position - this.transform.position).sqrMagnitude < 3*3 ){
    //opencheck to control the animation state
    openCheck+=1;
    //if is even play open animation else play close animation
    if(openCheck%2==0){
wardrobeAnimator.SetBool("isOpen", true);
    }else{
wardrobeAnimator.SetBool("isOpen", false);
    }


}
}
}
