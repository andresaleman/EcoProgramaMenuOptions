using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    //Button Management Variable
    private bool pressed;

    //Name of the next Scene to load
    private string enteredName;

    //Manage Time for Sound
    public const float TIME_LIMIT_SOUND = .1F;
    private float timer = 0F;

    //*
    //Set the pressed variable true to start timer for sound
    //then the given name Scene will load
    //*
    public void LoadOption(string name)
    {
        this.enteredName = name;
        pressed = true;
    }

    //Used for options that are going to be available after integration
    public void LoadOptionDebug(string name)
    {
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {   
        //start counting timer when button is pressed
        if(pressed)
        this.timer = this.timer + Time.deltaTime;

        //move to next menu scene when button sound end, based on TIME_LIMIT_SOUND
        if (this.timer >= TIME_LIMIT_SOUND)
        {
            timer = 0F;
            pressed = false;
            SceneManager.LoadScene(enteredName);
        }
    }

}
