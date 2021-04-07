using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoorControl : MonoBehaviour
{
    Animator _BdoorAnim;

    public AudioSource playSound;
    public bool sound = false;

    [SerializeField] private bool openTrigger = false;
    //[SerializeField] private bool closeTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
     if(other.CompareTag("red"))
     {
        if(openTrigger)
        {
          _BdoorAnim.SetBool("isOn" , false);
        }
        else {
          _BdoorAnim.SetBool("isOn", true);
          sound = true;
        }
      //  {
          //_FdoorAnim.SetBool("isOn", false);
       }


    }

    // Start is called before the first frame update
    void Start()
    {
        _BdoorAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if(sound==true){
        playSound.Play();
        sound = false;
      }
    }
  }
