﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;

    private List<Key.KeyType> keyList;
    public AudioSource doorBomb;
    public AudioSource pickup;
    public GameObject bridge;
    public GameObject table;



    private void Awake()
    {
        keyList = new List<Key.KeyType>();
        
    }

    public List<Key.KeyType> GetKeyList()
    {
        return keyList;
    }

    public void AddKey(Key.KeyType keyType)
    {
        Debug.Log("Added Key: " + keyType);
        keyList.Add(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ContainsKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider other)
    {
        Key key = other.GetComponent<Key>();
        if(key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
            pickup.Play();
        }

        KeyDoor keyDoor = other.GetComponent<KeyDoor>();
        if(keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyType()))
            {
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor();
                doorBomb.Play();
                bridge.SetActive(true);
                table.SetActive(false);
            }
            else
            {
                keyDoor.CloseDoor();
            }
            
        }
    }
}
