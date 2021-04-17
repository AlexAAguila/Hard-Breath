using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    
    [SerializeField] private DoorAnimator door;


    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        door.OpenDoor();
        Debug.Log("I'm being played");
    }

    public void CloseDoor()
    {
        door.CloseDoor();
    }
    
}
