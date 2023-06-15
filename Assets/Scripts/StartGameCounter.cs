using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameCounter : MonoBehaviour
{
    private float countdownTime = 5f;
    private TextMeshProUGUI countdownText;
    private ButtonsManager buttonsManager;

    public float CountdownTimerToBegin => countdownTime;

    // Start is called before the first frame update
    void Start()
    {
        countdownText = FindObjectOfType<CountBeginMark>().GetComponent<TextMeshProUGUI>();
        buttonsManager = GetComponent<ButtonsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;
        countdownText.text = countdownTime.ToString("0");

        if (countdownTime <= 0f)
        {
            buttonsManager.EnableButtons();
            Destroy(countdownText);
        }
    }
}
