using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_ykey : MonoBehaviour
{
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            GameObject.FindWithTag("manager").GetComponent<s_Inventory>().ykey = true;
            GameObject.Destroy(key);
        }
    }
}
