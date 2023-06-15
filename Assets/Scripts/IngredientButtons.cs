using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IngredientButtons : MonoBehaviour
{
    [SerializeField] private IngredientData ingredient;

    private SandwitchDisplay sandwitch;

    // Start is called before the first frame update
    void Start()
    {
        sandwitch = FindObjectOfType<SandwitchDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
