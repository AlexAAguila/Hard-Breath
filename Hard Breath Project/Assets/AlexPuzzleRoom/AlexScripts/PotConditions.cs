using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotConditions : MonoBehaviour
{
    //I made this code myself
    //This code is designed so that conditions need to be met in order to leave the room
    //The bottles are the only assets that have triggers so if both triggers go in the pot
    //then the condition is fulfilled


    public float amountOfBottles = 0;
    public AudioSource poor;
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        poor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if (amountOfBottles == 2) // Once both bottles are in then the condition is complete
        {
            Debug.Log("BOTTTLES!!!!");
            bomb.SetActive(true);
            Destroy(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
       amountOfBottles++; // Adding numbers of bottles
       Debug.Log("Bottle num = " + amountOfBottles);
        poor.Play();
    }

  
}
