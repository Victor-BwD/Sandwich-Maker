using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    private Button[] gameButtons;

    private void Start()
    {
        gameButtons = FindObjectsOfType<Button>();
        DisableButtons();
    }

    public void DisableButtons()
    {
        foreach (Button button in gameButtons)
        {
            button.interactable = false;
        }
    }

    public void EnableButtons()
    {
        foreach (Button button in gameButtons)
        {
            button.interactable = true;
        }
    }
}
