//Attach this script to a Toggle GameObject. To do this, go to Create>UI>Toggle.
//Set your own Text in the Inspector window

using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    Toggle music_Toggle;
    

    void Start()
    {
        //Fetch the Toggle GameObject
        music_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        music_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(music_Toggle);
        });
        
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        //Show the selected option
        if (!change.isOn)
        {
            Debug.Log("Off");
        }
        else
        {
            Debug.Log("On");
        }
    }
}