using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource SourceManager;

    //Audio Clips for the Game Narrative and Menu
    public AudioClip Bubble;
    public AudioClip GameIntro;
    public AudioClip Narrative1Sound;
    public AudioClip Narrative2Sound;
    public AudioClip Narrative3Sound;
    public AudioClip Narrative4Sound;
    public AudioClip Narrative5Sound;
    public AudioClip Narrative6Sound;
    public AudioClip Narrative7Sound;
    public AudioClip Narrative8Sound;
    public AudioClip Narrative9Sound;

    //Methods to start playing specific Audio Clips
    void Start()
    {
        SourceManager = GetComponent<AudioSource>();
    }

    public void ButtonSound()
    {
        SourceManager.PlayOneShot(Bubble);
    }

    public void GameIntroSound()
    {
        SourceManager.PlayOneShot(GameIntro);
    }

    public void Narrative1()
    {
        SourceManager.PlayOneShot(Narrative1Sound);
    }

    public void Narrative2()
    {
        SourceManager.PlayOneShot(Narrative2Sound);
    }

    public void Narrative3()
    {
        SourceManager.PlayOneShot(Narrative3Sound);
    }

    public void Narrative4()
    {
        SourceManager.PlayOneShot(Narrative4Sound);
    }

    public void Narrative5()
    {
        SourceManager.PlayOneShot(Narrative5Sound);
    }

    public void Narrative6()
    {
        SourceManager.PlayOneShot(Narrative6Sound);
    }

    public void Narrative7()
    {
        SourceManager.PlayOneShot(Narrative7Sound);
    }

    public void Narrative8()
    {
        SourceManager.PlayOneShot(Narrative8Sound);
    }

    public void Narrative9()
    {
        SourceManager.PlayOneShot(Narrative9Sound);
    }


}
