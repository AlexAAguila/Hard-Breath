using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_redKey : MonoBehaviour
{
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            GameObject.FindWithTag("manager").GetComponent<s_Inventory>().rkey = true;
            GameObject.Destroy(key);
        }
    }
}
