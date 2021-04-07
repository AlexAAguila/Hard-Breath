using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockKey : MonoBehaviour
{
//variables
    public GameObject key;
  public GameObject[] statue = new GameObject [4];
  
public Animator keyanimation;
    
    public Animator chest;
 //start function to find gameobject and its component
     void Start(){
    
      key = GameObject.Find("rust_key");
chest = GameObject.Find("chest").GetComponent<Animator>();
keyanimation = GameObject.Find("rust_key").GetComponent<Animator>();

     }

    //update function
    
    void Update(){
      //if key exists
    if(key != null){
      //get the rotation value from each statues
      float rotation=0;
      float sum =0;
      for(int i=0;i<4;i++){
        rotation = UnityEditor.TransformUtils.GetInspectorRotation(statue[i].transform).y;
        sum +=rotation;
      }
              //  var rotation = UnityEditor.TransformUtils.GetInspectorRotation(statue[0].transform).y;
              //  var rotation2 = UnityEditor.TransformUtils.GetInspectorRotation(statue[1].transform).y;
              //   var rotation3 = UnityEditor.TransformUtils.GetInspectorRotation(statue[2].transform).y;
              //    var rotation4 = UnityEditor.TransformUtils.GetInspectorRotation(statue[3].transform).y;
                 //get the sum of the rotation values
              //  var sum = rotation+ rotation2+rotation3+rotation4;
               //Debug.Log(sum);
    //check if all the statue  is facing the exit
if(rotation <= -90 && rotation >= -91 && sum<= -360 && sum >= -361 ){
         //if true, chest will open and key will show up
          key.GetComponent<MeshRenderer>().enabled=true;
          key.GetComponent<MeshCollider>().enabled=true;
          chest.SetBool("isOpen", true);
          keyanimation.SetBool("isOpen", true);
  }else{
    ////if false, chest will closed and key will not show up
      key.GetComponent<MeshRenderer>().enabled=false;
    key.GetComponent<MeshCollider>().enabled=false;
    chest.SetBool("isOpen", false);
    keyanimation.SetBool("isOpen", false);
  }
    }

    }
     
}
