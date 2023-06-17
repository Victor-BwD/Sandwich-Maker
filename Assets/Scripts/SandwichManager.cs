using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichManager : MonoBehaviour
{
    private static int sandwichsMadeNumber = 0;
    private static int errors = 0;
    private static int streak = 0;

    public static int SandwichsMadeNumber => sandwichsMadeNumber;

    public static void SandwichDoneCorrectly()
    {
        sandwichsMadeNumber++;
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
