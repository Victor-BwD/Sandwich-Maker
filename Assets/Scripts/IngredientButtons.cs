using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class IngredientButtons : MonoBehaviour
{
    [SerializeField] private IngredientData ingredient;

    private SandwitchDisplay sandwitch;
    private Image buttonImage;
    private ButtonsManager buttonsManager;
    private PointsManager pointsManager;

    private static int correctIngredientCount = 0;
    
    public static Action OnCorrectIngredientsCountReached;
    

    void Start()
    {
        sandwitch = FindObjectOfType<SandwitchDisplay>();
        buttonsManager = FindObjectOfType<ButtonsManager>();
        buttonImage = GetComponentInChildren<Image>();
        pointsManager = FindObjectOfType<PointsManager>();
    }

    private void Update()
    {
        if (correctIngredientCount == 3)
        {
            buttonsManager.ResetButtonColors(0.3f);
            correctIngredientCount = 0;
            SandwichManager.SandwichDoneCorrectly();
            pointsManager.IncreasePoints(50);

            OnCorrectIngredientsCountReached?.Invoke();
        }
    }

    // Used in Unity button inspector
    public void CheckIngredient()
    {
        var sandwichIngredients = sandwitch.RandonSandwichDisplayed.ingredients;

        if (sandwichIngredients.Contains(ingredient))
        {
            buttonImage.color = Color.green;
            correctIngredientCount++;
        }
        else
        {
            buttonImage.color = Color.red;
            SandwichManager.WrongSandwich();
            pointsManager.DecreasePoints(25);
        }
    }
}
