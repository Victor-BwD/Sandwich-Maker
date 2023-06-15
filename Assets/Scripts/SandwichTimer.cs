using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SandwichTimer : MonoBehaviour
{
    private float totalTime = 120f;
    private float currentTime = 0f;
    private TMP_Text countMakeSandwich;
    private bool isGameOver = false;

    private StartGameCounter gameCounterToStart;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
        countMakeSandwich = FindObjectOfType<CountToMakeSandwich>().GetComponent<TMP_Text>();
        countMakeSandwich.text = totalTime.ToString("F0");

        gameCounterToStart = FindObjectOfType<StartGameCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && gameCounterToStart.CountdownTimerToBegin <= 0f)
        {
            currentTime -= Time.deltaTime; 
            countMakeSandwich.text = currentTime.ToString("F0");

            if (currentTime <= 0f)
            {
                currentTime = 0f;
                EndGame();
            }
        }
    }

    private void EndGame()
    {
        isGameOver = true;
    }
}
