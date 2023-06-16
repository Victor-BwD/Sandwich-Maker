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

    private static int correctIngredientCount = 0;
    
    public static Action OnCorrectIngredientsCountReached;
    

    void Start()
    {
        sandwitch = FindObjectOfType<SandwitchDisplay>();
        buttonsManager = FindObjectOfType<ButtonsManager>();
        buttonImage = GetComponentInChildren<Image>();
    }

    private void Update()
    {
        if (correctIngredientCount == 3)
        {
            buttonsManager.ResetButtonColors(0.3f);
            correctIngredientCount = 0;
            SandwichMananger.SandwichDoneCorrectly();

            OnCorrectIngredientsCountReached?.Invoke();
        }
    }

    // Used in Unity button inspector
    public void CheckIngredient()
    {
        var sandwichIngredients = sandwitch.RandonSandwichDisplayed.ingredients;

        if (sandwichIngredients.Contains(ingredient))
        {
            Debug.Log("Acertou um ingrediente");
            buttonImage.color = Color.green;
            correctIngredientCount++;
        }
        else
        {
            Debug.Log("Errou");
            buttonImage.color = Color.red;
            SandwichMananger.WrongSandwich();
        }
    }
}
