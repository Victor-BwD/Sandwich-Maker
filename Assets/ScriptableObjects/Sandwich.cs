using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sandwich", menuName = "Sandwich")]
public class Sandwich : ScriptableObject
{
    public string SandwichName;
    public Sprite Artwork;
    public IngredientData[] ingredients;
}
