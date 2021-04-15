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
                if (myInventory.GetComponent<s_Inventory>().rkey)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 2)
            {
                if (myInventory.GetComponent<s_Inventory>().bkey)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 3)
            {
                if (myInventory.GetComponent<s_Inventory>().gkey)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 4)
            {
                if (myInventory.GetComponent<s_Inventory>().ykey)
                {
                    Destroy(gameObject);
                }
            }
            if (puzzleNumber == 5)
            {
                
                    Destroy(gameObject);
            }
            if (puzzleNumber == 6)
            {
                
                    Destroy(gameObject);
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
                myInventory.GetComponent<s_Inventory>().rkey = true;
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 2)
            {
                myInventory.GetComponent<s_Inventory>().bkey = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 3)
            {
                myInventory.GetComponent<s_Inventory>().gkey = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            if (puzzleNumber == 4)
            {
                myInventory.GetComponent<s_Inventory>().ykey = true;
                
                Destroy(gameObject);
                Debug.Log("Bump");
            }
            
        }
    }
}
