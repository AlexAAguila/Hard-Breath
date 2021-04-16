using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_endCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            //check if the inventory manager's items list is all good
            if (GameObject.Find("InventoryManager").GetComponent<s_Inventory>().keyCheck())
            {
                //move to new room
                Debug.Log("END");
            }
            else
            {
                //show on GUI that the player still needs keys
                Debug.Log("Not yet");
            }
        }
    }

    
}
