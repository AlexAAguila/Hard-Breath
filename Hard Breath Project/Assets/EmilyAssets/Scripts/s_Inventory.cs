using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s_Inventory : MonoBehaviour
{
    public bool rkey,bkey,gkey,ykey;
    public GameObject myPlayer;
    public string previousRoom;

    private bool firstFrame, secondFrame, thirdFrame, fourthFrame;

    //singleton logic taken from unitygeek.com/unity_c_singleton

    private static s_Inventory instance = null;
    public static s_Inventory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<s_Inventory>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "InventoryManager";
                    instance = go.AddComponent<s_Inventory>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            previousRoom = "";
            firstFrame = true;
            secondFrame = false;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
            
        }
    }

    //on start, check if we're in the BottomFloor. If we are, check if previousRoom is anything other than ""
    //if previousRoom is a name of a room, move the player to the appropriate area

    void Start()
    {
        
        myPlayer = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        
        if (fourthFrame)
        {
            
            Debug.Log("Previous room: " + previousRoom);
            
                Debug.Log("Finding Player");
                myPlayer = GameObject.FindWithTag("Player");
                if (myPlayer != null)
                {
                    myPlayer.GetComponent<CharacterController>().enabled = false;
                }
                else
                {
                    Debug.Log("No player found");
                }

            if (SceneManager.GetActiveScene().name == "BottomFloor" && previousRoom != "")
            {
                Debug.Log("Checking spawn points");
                //check for each scene name
                if (previousRoom == "BedRoom")
                {
                    Debug.Log("From Bedroom");
                    GameObject temp = GameObject.Find("BedRoomSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "MAze")
                {
                    GameObject temp = GameObject.Find("MazeSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "statuescene")
                {
                    GameObject temp = GameObject.Find("StatueSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "diningroom")
                {
                    GameObject temp = GameObject.Find("DiningSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "AlexPuzzleRoom")
                {
                    GameObject temp = GameObject.Find("AlexSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "JPTO Puzzle")
                {
                    GameObject temp = GameObject.Find("JPTOSpawn");
                    myPlayer.transform.position = temp.transform.position;
                    myPlayer.transform.rotation = temp.transform.rotation;
                }
                else if (previousRoom == "Empty Room")
                {
                    Debug.Log("From Empty");
                    GameObject temptemp = GameObject.Find("EmptySpawn");
                    myPlayer.transform.position = temptemp.transform.position;
                    myPlayer.transform.Rotate(0f,180f,0f , Space.Self);
                }

            }
            fourthFrame = false;
            myPlayer.GetComponent<CharacterController>().enabled = true;
            Debug.Log("Done checking");
        }
        if (thirdFrame)
        {
            thirdFrame = false;
            fourthFrame = true;
        }
        if (secondFrame)
        {
            secondFrame = false;
            thirdFrame = true;
        }
        if (firstFrame)
        {
            firstFrame = false;
            secondFrame = true;
        }
        
        
    }

    public void setPreviousRoom(string name)
    {
        previousRoom = name;
    }

    public void resetFirstFrame()
    {

        firstFrame = true;
        secondFrame = false;
    }

    public void setPlayer(GameObject player)
    {
        myPlayer = player;
    }

    public bool keyCheck()
    {
        if (rkey && bkey && gkey && ykey) return true;
        else return false;
    }
}
