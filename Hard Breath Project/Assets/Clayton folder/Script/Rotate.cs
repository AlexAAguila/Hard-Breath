using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
  //variable
    public GameObject player;
  public float rotation;
    void Start(){
      player = GameObject.Find("FPSController");
     
      
    }
//on mouse down to rotate the statues
  void OnMouseDown(){
    //check if the player in range
       if ((player.transform.position - this.transform.position).sqrMagnitude < 3*3){
         //rotate statue
           transform.Rotate(0, 90f, 0);
           //get the roation value
          rotation = UnityEditor.TransformUtils.GetInspectorRotation(this.transform).y;
          rotation+=rotation;
  
      }

           
    
}
}
