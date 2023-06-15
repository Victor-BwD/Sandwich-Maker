using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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

    public async void ResetButtonColors(float delay)
    {
        await Task.Delay(TimeSpan.FromSeconds(delay));

        foreach (Button button in gameButtons)
        {
            Image buttonImage = button.GetComponent<Image>();
            buttonImage.color = Color.white;
        }
    }
}
