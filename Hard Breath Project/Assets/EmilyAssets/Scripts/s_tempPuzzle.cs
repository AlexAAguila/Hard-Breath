using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_tempPuzzle : MonoBehaviour
{
    [Range(1,6)]
    public int puzzleNumber;
    private GameObject myInventory;
    
    private void Start()
    {
        //check to see if this puzzle is supposed to be solved. If so, delete puzzle piece
        myInventory = GameObject.Find("InventoryManager");

        if (myInventory)
        {
            if (puzzleNumber == 1)
            {
                if (myInventory.GetComponent<s_Inventory>().item1)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 2)
            {
                if (myInventory.GetComponent<s_Inventory>().item2)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 3)
            {
                if (myInventory.GetComponent<s_Inventory>().item3)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 4)
            {
                if (myInventory.GetComponent<s_Inventory>().item4)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 5)
            {
                if (myInventory.GetComponent<s_Inventory>().item5)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 6)
            {
                if (myInventory.GetComponent<s_Inventory>().item6)
                {
                    Destroy(gameObject);
                }
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            //toggle the puzzle as completed

            if (puzzleNumber == 1)
            {
                myInventory.GetComponent<s_Inventory>().item1 = true;
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 2)
            {
                myInventory.GetComponent<s_Inventory>().item2 = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 3)
            {
                myInventory.GetComponent<s_Inventory>().item3 = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 4)
            {
                myInventory.GetComponent<s_Inventory>().item4 = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 5)
            {
                myInventory.GetComponent<s_Inventory>().item5 = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 6)
            {
                myInventory.GetComponent<s_Inventory>().item6 = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
        }
    }
}
