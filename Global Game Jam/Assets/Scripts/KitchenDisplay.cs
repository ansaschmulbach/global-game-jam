using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KitchenDisplay : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI recipeText;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Recipe.currentRecipe != null)
        {
            UpdateRecipe();
            UpdateScore();   
        }
    }

    public void UpdateRecipe()
    {
        this.recipeText.text = Recipe.currentRecipe[Recipe.currentStepIndex].ToString();
    }

    public void UpdateScore()
    {
        this.scoreText.text = "Score: " + GameManager.instance.gameState.points;
    }
    
}
