using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class s_endCheck : MonoBehaviour
{
    public GameObject myText;
    private bool movedAway;

    void Start()
    {
        movedAway = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            //check if the inventory manager's items list is all good
            if (GameObject.Find("InventoryManager").GetComponent<s_Inventory>().keyCheck())
            {
                if (!movedAway)
                {
                    //move to end room
                    GameObject manager = GameObject.Find("InventoryManager");
                    manager.GetComponent<s_Inventory>().setPreviousRoom(SceneManager.GetActiveScene().name);
                    GameObject.FindWithTag("fader").GetComponent<s_fadeIn>().beginFadeOut("EndingScene");
                    movedAway = true;
                }
            }
            else
            {
                //show on GUI that the player still needs keys
                Debug.Log("Not yet");
                myText.GetComponent<RawImage>().color = new Color (myText.GetComponent<RawImage>().color.r,myText.GetComponent<RawImage>().color.g,myText.GetComponent<RawImage>().color.b,1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
        //hide the text
        myText.GetComponent<RawImage>().color = new Color (myText.GetComponent<RawImage>().color.r,myText.GetComponent<RawImage>().color.g,myText.GetComponent<RawImage>().color.b,0);
        }
    }

    
}
