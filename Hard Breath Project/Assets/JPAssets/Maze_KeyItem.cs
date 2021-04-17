using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_KeyItem : MonoBehaviour
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
        GameObject.FindWithTag("manager").GetComponent<s_Inventory>().rkey = true;
        Destroy(this.gameObject);

    }
}
