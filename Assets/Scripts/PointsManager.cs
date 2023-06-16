using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    private int points;

    private void Start()
    {
        pointsText.text = points.ToString();
    }

    public void IncreasePoints(int points)
    {
        this.points += points;
        pointsText.text = this.points.ToString();

        var extraPoints = GetExtraPoints();
        this.points += extraPoints;
        pointsText.text = this.points.ToString();
    }

    public void DecreasePoints(int points)
    {
        if (this.points <= 0) return;

        this.points -= points;
        pointsText.text = this.points.ToString();
    }

    private int GetExtraPoints()
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
