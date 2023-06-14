using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameCounter : MonoBehaviour
{
    public float countdownTime = 5f;
    private TextMeshProUGUI countdownText;


    // Start is called before the first frame update
    void Start()
    {
        countdownText = FindObjectOfType<CountBeginMark>().GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;
        countdownText.text = countdownTime.ToString("0");

        if (countdownTime <= 0f)
        {
            Destroy(countdownText);
        }
    }
}
