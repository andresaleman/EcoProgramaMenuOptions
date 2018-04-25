//Attach this script to a Toggle GameObject. To do this, go to Create>UI>Toggle.
//Set your own Text in the Inspector window

using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    Toggle sound_Toggle;


    void Start()
    {
        //Fetch the Toggle GameObject
        sound_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        sound_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(sound_Toggle);
        });
        
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        //Print toggle state
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