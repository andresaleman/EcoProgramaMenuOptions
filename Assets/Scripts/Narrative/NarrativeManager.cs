using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeManager : MonoBehaviour {

    public string nextSceneName;
    public const float TIME_LIMIT = 5F;
    private float timer = 0F;
	
	// Update is called once per frame
	void Update () {
        this.timer = this.timer + Time.deltaTime;
        if(this.timer >= TIME_LIMIT)
        {
            Application.LoadLevel("Narrative2");
        }
	}
}
