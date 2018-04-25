using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {

    [SerializeField]
    SoundManager sound;

    public const float TIME_LIMIT = .1F;
    private float timer = 0F;
    private bool start = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.timer = this.timer + Time.deltaTime;
        if (this.timer >= TIME_LIMIT && !start)
        {
            start = true;
            sound.GameIntroSound();
        }
    }
}
