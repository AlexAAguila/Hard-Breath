using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class s_fadeIn : MonoBehaviour
{
    public float fadeTime;
    public bool startFadeIn;
    public bool fadingIn;
    public bool startFadeOut;
    public bool fadingOut;
    public float fadeSpeed = 0.05f;
    public float currentFade = 0.0f;
    public float delayTimer = 4.0f;
    public GameObject myScreenFade;
    //public GameObject myPlayer;

    public RawImage myFade;
    public Texture myTitleScreen;

    //private Color fadeColor;

    void Start()
    {
        startFadeIn = true;
        fadingIn= false;
        fadingOut = false;
        startFadeOut = false;

        myFade = myScreenFade.GetComponent<RawImage>();

        //fadeColor = myFade.GetComponent<Image>().color;

        if (myScreenFade == null) myScreenFade = GameObject.Find("Directional Light");
        //if (myPlayer == null) myPlayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (delayTimer > 0)
        {
            delayTimer -= Time.fixedDeltaTime;
        }
        else
        {
            if (startFadeIn)
            {
                startFadeIn = false;
                fadingIn = true;
                currentFade = 0.0f;
            }
            if (startFadeOut)
            {
                startFadeOut = false;
                fadingOut = true;
                currentFade = 1.0f;
            }

            if (fadingIn)
            {
                if (currentFade <=1)
                {
                    currentFade+= fadeSpeed;
                    //myScreenFade.GetComponent<Light>().intensity = currentFade;
                    //Debug.Log(255 * (1-currentFade));
                    myFade.color = new Color(myFade.color.r, myFade.color.g, myFade.color.b, 1-currentFade);
                    //myFade.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,currentFade);

                
                }
                else
                {
                    fadingIn = false;               
                }
            }
            else if (fadingOut)
            {
                if (currentFade > 0)
                {
                    currentFade -= fadeSpeed;
                    //myScreenFade.GetComponent<Light>().intensity = currentFade;
                    //Debug.Log(currentFade);
                    myFade.color = new Color(myFade.color.r, myFade.color.g, myFade.color.b, 1-currentFade);
                    //myScreenFade.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f, currentFade);                
                }
                else
                {
                    SceneManager.LoadScene("BottomFloor");
                    fadingOut = false;
                }
            }

            //listen to any key input to start fading and moving to bottom floor
            if (!fadingIn && !fadingOut)
            {
                if (Input.anyKeyDown)
                {
                    fadingOut = true;
//                    
                }
            }
        }
    }

    public void beginFadeIn()
    {
        startFadeIn = true;

    }

    public void beginFadeOut()
    {
        startFadeOut = true;
    }

    void OnGUI()
    {
        
       //GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), myTitleScreen, ScaleMode.ScaleToFit, true);
    }
}
