using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    //variable
    public GameObject popUpBox;
    public Animator animator;
    public TextMeshProUGUI popUpText;
//popup function to make the gui active 
    public void PopUp(string text){
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("pop");
       

    }
}
