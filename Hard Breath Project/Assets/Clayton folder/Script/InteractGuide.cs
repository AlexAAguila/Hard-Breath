using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractGuide : MonoBehaviour
{
    public string myString;
    public TextMeshProUGUI myText;
    
    public bool displayInfo;
    private TMP_Text ttext;
     public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    ttext = GameObject.Find("Guide").GetComponent<TMP_Text>();
    player = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        //print(player.transform.position);
        if ((player.transform.position - this.transform.position).sqrMagnitude < 2*2){
            ttext.text = myString;
            
        }else{
            ttext.text = "";
        }
        //FadeText();
    //print(displayInfo);
    }
    void OnMouseOver(){
        displayInfo = true;
    }
    void OnMouseExit(){
        displayInfo = false;
    }
    void FadeText(){
    if(displayInfo){
        ttext.text = myString;
        }else{
            ttext.text = "";
        }
    }
}
