using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichMananger : MonoBehaviour
{
    private static int sandwichDoneNumber = 0;
    private static int errors = 0;

    public static void SandwichDoneCorrectly()
    {
        sandwichDoneNumber++;
    }

    public static void WrongSandwich()
    {
        errors++;
    }
}
