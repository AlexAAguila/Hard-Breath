using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    
    public Transform startPosition;
    public Transform stringStart;
    public Transform bombStart;
    
    //public GameObject player;
    public GameObject player;
    public GameObject bString;
    public GameObject bomb;

    // Start is called before the first frame update
    void Start()
    {
        /*
        startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        bombStart = new Vector3(bomb.transform.position.x, bomb.transform.position.y, bomb.transform.position.z);
        stringStart = new Vector3(bString.transform.position.x, bString.transform.position.y, bString.transform.position.z);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.position = startPosition.transform.position;
            Debug.Log("passed");
        }
        if (other.gameObject == bString)
        {
            bString.transform.position = stringStart.transform.position;
            Debug.Log("passed");
        }
        if (other.gameObject == bomb)
        {
            bomb.transform.position = bombStart.transform.position;
            Debug.Log("passed");
        }
    }
}
