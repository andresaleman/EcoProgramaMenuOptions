using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour {

    public Button Nivel1;
    public Button Nivel2;
    public Button Nivel3;

    //Load a new level or menu scene
    public void SetLevel(string number)
    {
        switch (number) //Set the global level variable according to button pressed
        {
            case "Nivel1":
                Debug.Log("Change Global Variable to Level 1");
                //PersistentGameManager.Instance.currentGameLevel = 1;
                break;
            case "Nivel2":
                Debug.Log("Change Global Variable to Level 2");
                //PersistentGameManager.Instance.currentGameLevel = 2;
                break;
            case "Nivel3":
                Debug.Log("Change Global Variable to Level 3");
                //PersistentGameManager.Instance.currentGameLevel = 3;
                break;

        }
         
    }

    public void SetButton(Button buttonSelected)
    {
        switch (buttonSelected.name) //set the button color according to the pressed button
        {
            case "Nivel1":
                Nivel2.GetComponent<Image>().color = Color.yellow;
                Nivel3.GetComponent<Image>().color = Color.yellow;
                buttonSelected.GetComponent<Image>().color = Color.red;
                break;
            case "Nivel2":
                Nivel1.GetComponent<Image>().color = Color.yellow;
                Nivel3.GetComponent<Image>().color = Color.yellow;
                buttonSelected.GetComponent<Image>().color = Color.red;
                break;
            case "Nivel3":
                Nivel1.GetComponent<Image>().color = Color.yellow;
                Nivel2.GetComponent<Image>().color = Color.yellow;
                buttonSelected.GetComponent<Image>().color = Color.red;
                break;

        }
    }
}
