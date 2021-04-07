using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Inventory : MonoBehaviour
{
    public bool item1,item2,item3,item4,item5,item6;


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
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
