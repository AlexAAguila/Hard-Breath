using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BottleCondition : MonoBehaviour
{
    private Transform container;
    private Transform bottleTemplate;
    public GameObject condition;//To access the ammount of bottles in cauldron
    public float bottleNum;// To set the amount of bottles poored so that the sprites disappear
    public PotConditions b;//Accessing amountOfBottles from PotConditions
    private void Awake()
    {
        container = transform.Find("container");
        bottleTemplate = container.Find("bottleTemplate");
        bottleTemplate.gameObject.SetActive(true);
    }

    private void Start()
    {
        b = condition.GetComponent<PotConditions>();
    }

    private void Update()
    {
        if (b.amountOfBottles == bottleNum)
        {

            UpdateVisual();
        }
    }


    private void UpdateVisual()
    {
  
        bottleTemplate.gameObject.SetActive(false);


    }
}
