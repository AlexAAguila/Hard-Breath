using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
  //variables
public string popUp;
  public GameObject player;
  public Popup pop;
  public float rotation;
  private int count;
  private bool clicked=false;
  public Button button;
  //start function to find gameobject and its component
    void Start(){
      player = GameObject.Find("FPSController");
     pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Popup>();
     button = GameObject.Find("Button").GetComponent<Button>();
     
    }
 //update function
 void Update(){
    
   //check if the player in range of the book and click the book         
      if ((player.transform.position - this.transform.position).sqrMagnitude < 3*3 && Input.GetMouseButtonDown(0)){
  //call the onclick function to see if the button is clicked
 button.onClick.AddListener(TaskOnClick);
 //set the state of the gui
count=1;
//check if the button is clicked or not 
 clicked=false;
 

//call the popup function to make the gui show up in front of the player
     pop.PopUp(popUp);
   
     
 }
 //check if the gui is showed or not
 if(count==1 && clicked==false){
   //make the cursor show up
Cursor.lockState = CursorLockMode.Confined;
             Cursor.visible = true;
           
 }else{
   //hide the cursor
            Cursor.lockState = CursorLockMode.Locked;
             Cursor.visible = false;  
        }  
}
//check if the button is clicked
void TaskOnClick(){
      
    clicked=true;
    }
}
