using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class SliderManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider soundSlider;

    public void Start()
    {
        //Adds a listener to the sliders and invokes a method when the value changes.
        musicSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        soundSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        //Show the change in slider
        Debug.Log("Music: ");
        Debug.Log(musicSlider.value);
        Debug.Log(" Sound: ");
        Debug.Log(soundSlider.value);
        //For integration change the global variable for sound and music options
    }
}
