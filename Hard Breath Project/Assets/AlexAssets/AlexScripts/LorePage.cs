using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorePage : MonoBehaviour


{

    public Transform player; // Reference to player
    public GameObject paper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 1.5f)
        {
            paper.SetActive(true);
        }
        else
        {
            paper.SetActive(false);
        }

   
    }
}
