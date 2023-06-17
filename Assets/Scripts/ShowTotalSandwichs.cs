using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowTotalSandwichs : MonoBehaviour
{
    private TMP_Text totalSandwichsText;
    
    void Start()
    {
        totalSandwichsText = GetComponent<TMP_Text>();
        
        totalSandwichsText.text = SandwichManager.SandwichsMadeNumber.ToString();
    }
}
