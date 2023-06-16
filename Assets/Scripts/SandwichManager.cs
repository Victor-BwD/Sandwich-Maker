using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichManager : MonoBehaviour
{
    private static int sandwichDoneNumber = 0;
    private static int errors = 0;
    private static int streak = 0;

    public static void SandwichDoneCorrectly()
    {
        sandwichDoneNumber++;
        streak++;
    }

    public static void WrongSandwich()
    {
        errors++;
        streak = 0;
    }

    public static int SandwichDoneStreak()
    {
        return streak;
    }
}
