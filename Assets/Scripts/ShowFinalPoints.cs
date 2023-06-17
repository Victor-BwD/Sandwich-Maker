using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowFinalPoints : MonoBehaviour
{
    private TMP_Text totalPointsText;
    private PointsManager pointsManager;

    void Start()
    {
        totalPointsText = GetComponent<TMP_Text>();
        pointsManager = FindObjectOfType<PointsManager>();

        totalPointsText.text = pointsManager.Points.ToString();
    }
}
