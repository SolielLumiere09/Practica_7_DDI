using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikuControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Animation animation;
    private Boolean pressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {

        if (!pressed)
        {
           
            pressed = true;
            audioSource.Play();
            animation.Play();
        }
        else
        {
            pressed = false;
            audioSource.Stop();
            animation.Stop();
        }



    }

}