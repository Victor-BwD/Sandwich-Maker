using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SandwitchDisplay : MonoBehaviour
{
    public Sandwich[] sandwiches; // Array contendo todos os possíveis Scriptable Objects de sanduíches

    public TMP_Text Name;
    public SpriteRenderer Artwork;
    public SpriteRenderer ingredientImage1;
    public SpriteRenderer ingredientImage2;
    public SpriteRenderer ingredientImage3;

    void Start()
    {
        GenerateRandomSandwich();
    }

    void GenerateRandomSandwich()
    {
        Sandwich randomSandwich = sandwiches[Random.Range(0, sandwiches.Length)];

        Artwork.sprite = randomSandwich.Artwork;
        Name.text = randomSandwich.SandwichName;
        ingredientImage1.sprite = randomSandwich.ingredients[0].ingredientIcon;
        ingredientImage2.sprite = randomSandwich.ingredients[1].ingredientIcon;
        ingredientImage3.sprite = randomSandwich.ingredients[2].ingredientIcon;
    }
}
