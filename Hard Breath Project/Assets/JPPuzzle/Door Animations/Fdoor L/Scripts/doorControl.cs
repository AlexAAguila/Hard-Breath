using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{

    Animator _FdoorAnim;

    public AudioSource playSound;
    public bool sound = false;

    [SerializeField] private bool openTrigger = false;
    //[SerializeField] private bool closeTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
     if(other.CompareTag("blue"))
     {
        if(openTrigger)
        {
          _FdoorAnim.SetBool("isOn" , false);
        }
        else {
          _FdoorAnim.SetBool("isOn", true);
          sound = true;
        }
      //  {
          //_FdoorAnim.SetBool("isOn", false);
       }


    }

    // Start is called before the first frame update
    void Start()
    {
        _FdoorAnim = this.transform.parent.GetComponent<Animator>();
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
