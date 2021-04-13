using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s_fadeIn : MonoBehaviour
{
    public float fadeTime;
    public bool startFadeIn;
    public bool fadingIn;
    public bool startFadeOut;
    public bool fadingOut;
    public float fadeSpeed = 0.05f;
    public float currentFade = 0.0f;
    public float delayTimer = 5.0f;
    public GameObject myScreenFade;
    //public GameObject myPlayer;

    
    void Start()
    {
        startFadeIn = true;
        fadingIn= false;
        fadingOut = false;
        startFadeOut = false;

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
                currentFade = 1.0f;
            }
            if (startFadeOut)
            {
                startFadeOut = false;
                fadingOut = true;
                currentFade = 0.0f;
            }

            if (fadingIn)
            {
                if (currentFade <=2)
                {
                    currentFade+= fadeSpeed;
                    myScreenFade.GetComponent<Light>().intensity = currentFade;
                
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
                    myScreenFade.GetComponent<Light>().intensity = currentFade;                
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
}
