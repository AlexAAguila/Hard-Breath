using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_KeyItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindWithTag("manager").GetComponent<s_Inventory>().gkey = true;
        Destroy(this.gameObject);

    }
}
