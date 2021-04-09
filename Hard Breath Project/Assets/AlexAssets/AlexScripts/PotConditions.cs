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
    public AudioSource build;
    public GameObject bomb;

    //To set conditions
    public GameObject bombPart;
    public GameObject bombString;


    //To set the visible gameobjects on the table
    public GameObject bombPartTable;
    public GameObject bombStringTable;
    // Start is called before the first frame update
    void Start()
    {
        build = GetComponent<AudioSource>();
        bomb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (amountOfBottles == 2) // Once both bottles are in then the condition is complete
        {
            Debug.Log("BOTTTLES!!!!");
            bombPartTable.SetActive(false);
            bombStringTable.SetActive(false);
            bomb.SetActive(true);
            build.Play();

            Destroy(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Instead of setting positions, I just destoyed the gameobject that can be moved. Then Set the preset gameobject to visible
        if (other.gameObject == bombPart)
        {
            bombPartTable.SetActive(true);
        }
        if (other.gameObject == bombString)
        {
            bombStringTable.SetActive(true);

        }
        Destroy(other.gameObject);
       amountOfBottles++; // Adding numbers of bottles
       Debug.Log("Bottle num = " + amountOfBottles);
    }

  
}
