using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeSceneManager : MonoBehaviour {
    
    public string nextSceneName;

    public float TIME_LIMIT;

    public const float TIME_LIMIT_AUDIO = .01F;
    private float timer = 0F;
    private bool start = false;

    [SerializeField]
    SoundManager sound;

    // Update is called once per frame
    void Update()
    {
        this.timer = this.timer + Time.deltaTime;

        //Load the next scene of narrative
        if (this.timer >= (TIME_LIMIT - .09))
        {
            Application.LoadLevel(nextSceneName);
        }

        //Load the sound of the narrative's scene
        if(this.timer >= TIME_LIMIT_AUDIO && !start)
        {
            start = true;
            if (nextSceneName.Equals("Narrative2"))
                sound.Narrative1();
            else if (nextSceneName.Equals("Narrative3"))
                sound.Narrative2();
            else if (nextSceneName.Equals("Narrative4"))
                sound.Narrative3();
            else if (nextSceneName.Equals("Narrative5"))
                sound.Narrative4();
            else if (nextSceneName.Equals("Narrative6"))
                sound.Narrative5();
            else if (nextSceneName.Equals("Narrative7"))
                sound.Narrative6();
            else if (nextSceneName.Equals("Narrative8"))
                sound.Narrative7();
            else if (nextSceneName.Equals("Narrative9"))
                sound.Narrative8();
            else if (nextSceneName.Equals("Main"))
                sound.Narrative9();
        }
    }
}
