using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s_RoomMove : MonoBehaviour
{
    [SerializeField] private string sceneName; //[SerializeField] allows you to see private variables in the editor without making them public

    private GameObject manager;

    private void Awake()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            Debug.Log("Loading Scene: " + sceneName);
            manager = GameObject.Find("InventoryManager");
            manager.GetComponent<s_Inventory>().setPreviousRoom(SceneManager.GetActiveScene().name);
            manager.GetComponent<s_Inventory>().resetFirstFrame();
            //GameObject.FindWithTag("Manager").GetComponent<s_Inventory>().resetFirstFrame();
            SceneManager.LoadScene(sceneName);
        }
    }
}
