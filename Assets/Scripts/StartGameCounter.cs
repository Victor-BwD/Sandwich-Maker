using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameCounter : MonoBehaviour
{
    private float countdownTime = 5f;
    private TextMeshProUGUI countdownText;
    private ButtonsManager buttonsManager;
    private GameObject StartText;

    public float CountdownTimerToBegin => countdownTime;

    void Start()
    {
        countdownText = FindObjectOfType<CountBeginMark>().GetComponent<TextMeshProUGUI>();
        buttonsManager = GetComponent<ButtonsManager>();
        StartText = FindObjectOfType<StartTextMark>(true).gameObject;
    }

    void Update()
    {
        DecrementTimerToBeginGame();
    }

    private void DecrementTimerToBeginGame()
    {
        if (countdownTime == 0f) return;

        countdownTime -= Time.deltaTime;
        countdownText.text = countdownTime.ToString("0");

        if (countdownTime <= 0f)
        {
            buttonsManager.EnableButtons();
            ShowStartText();
            Destroy(countdownText);
        }
    }

    private void ShowStartText()
    {
        if (StartText == null) return; // Avoid null error

        StartText.SetActive(true);
        Destroy(StartText.gameObject, 4f);
    }
}
