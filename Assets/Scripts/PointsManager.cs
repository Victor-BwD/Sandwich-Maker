using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    private int points;

    public int Points => points;

    private void Start()
    {
        pointsText.text = points.ToString();
    }

    public void IncreasePoints(int points) // Increase points when hit
    {
        this.points += points;
        pointsText.text = this.points.ToString();

        var extraPoints = GetExtraPoints();
        this.points += extraPoints;
        pointsText.text = this.points.ToString();
    }

    public void DecreasePoints(int points) // Decrease points when wrong
    {
        if (this.points <= 0) return;

        this.points -= points;
        pointsText.text = this.points.ToString();
    }

    private int GetExtraPoints() // Function to return a value for extra point when in streak
    {
        var streak = SandwichManager.SandwichDoneStreak();

        var extraPoints = 0;
        if (streak >= 3)
        {
            extraPoints += 30;
        }
        if (streak >= 7)
        {
            extraPoints += 60;
        }

        return extraPoints;
    }
}
