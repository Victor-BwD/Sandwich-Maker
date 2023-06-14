using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichTimer : MonoBehaviour
{
    private float totalTime = 120f;
    private float currentTime = 0f;

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            currentTime -= Time.deltaTime; 

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
