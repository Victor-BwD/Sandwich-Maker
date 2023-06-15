using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IngredientButtons : MonoBehaviour
{
    [SerializeField] private IngredientData ingredient;

    private SandwitchDisplay sandwitch;

    void Start()
    {
        sandwitch = FindObjectOfType<SandwitchDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Used in Unity button inspector
    public void CheckIngredient()
    {
        if (sandwitch.RandonSandwichDisplayed.ingredients.Contains(ingredient))
        {
            Debug.Log("Acertou um ingrediente");
        }
        else
        {
            Debug.Log("Errou");
        }
    }
}
