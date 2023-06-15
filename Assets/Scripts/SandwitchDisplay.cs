using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SandwitchDisplay : MonoBehaviour
{
    public Sandwich[] sandwiches; 

    public TMP_Text Name;
    public SpriteRenderer Artwork;
    public SpriteRenderer ingredientImage1;
    public SpriteRenderer ingredientImage2;
    public SpriteRenderer ingredientImage3;

    private Sandwich randomSandwich;

    void Start()
    {
        GenerateRandomSandwich();
    }

    void GenerateRandomSandwich()
    {
        randomSandwich = sandwiches[Random.Range(0, sandwiches.Length)];

        Artwork.sprite = randomSandwich.Artwork;
        Name.text = randomSandwich.SandwichName;
        ingredientImage1.sprite = randomSandwich.ingredients[0].ingredientIcon;
        ingredientImage2.sprite = randomSandwich.ingredients[1].ingredientIcon;
        ingredientImage3.sprite = randomSandwich.ingredients[2].ingredientIcon;
    }

    public void Check(IngredientData ingredient)
    {
        if (randomSandwich.ingredients.Contains(ingredient))
        {
            Debug.Log("Acertou um ingrediente");
        }
        else
        {
            Debug.Log("Errou");
        }
    }

    
}
