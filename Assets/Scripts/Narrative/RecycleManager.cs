using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecycleManager : MonoBehaviour {

    public string nextSceneName;
    public const float TIME_LIMIT = 9F;
    public const float TIME_LIMIT_AUDIO = .1F;
    private float timer = 0F;
    public Text Text1;
    public Text Text2;
    public Text Paragraph1;
    public int step = 0;
    public bool start = false;

    [SerializeField]
    SoundManager sound;

    // Update is called once per frame
    void Update()
    {
        this.timer = this.timer + Time.deltaTime;
        if (this.timer >= TIME_LIMIT)
        {
            Application.LoadLevel(nextSceneName); //start next scene
        }
        else if (this.timer >= 4.5F & step == 1) //add cristal to recycling symbol
        {
            Text1.text = "Cristal";
            Paragraph1.text = Paragraph1.text + "\nCristal";
            step++;
        }
        else if (this.timer >= 3F & step == 0) //add aluminum to recycling symbol
        {
            Text2.text = "Aluminio";
            Paragraph1.text = Paragraph1.text + "\nAluminio";
            step++;
        }

        if (this.timer >= TIME_LIMIT_AUDIO && !start) //start narrative sound
        {
            start = true;
            sound.Narrative4();
        }
    }
}
