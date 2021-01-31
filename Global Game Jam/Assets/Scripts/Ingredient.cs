using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Ingredient : MonoBehaviour
{
    public bool cooked = false;
    public int pointsEarned = 0;
    public List<Commands> validCommands;
    public string name;

    void Trash()
    {
        Destroy(this.gameObject);
    }

    void Inventory()
    {
        GameManager.instance.gameState.inventory = this.gameObject;
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void Deinventory()
    {
        GameManager.instance.gameState.inventory = null;
    }

    public void Cook()
    {
        Recipe.Step step = Recipe.currentRecipe[Recipe.currentStepIndex];
        if (!cooked)
        {
            CookIngredient();
            cooked = true;
            Debug.Log("Inside Ingredient cook: " + 
                      getCommand() + ", " + step.command + "; " + name + ", " +
                      step.ingredient.name);
            if (getCommand() == step.command)
            {
                pointsEarned += (int)(GameState.PointsPer * 0.5f);
            }

            if (this.name.Equals(step.ingredient.name))
            {
                pointsEarned += (int)(GameState.PointsPer * 0.5f);
            }
            
        }
    }

    public abstract string GetRecipeLine();
    protected abstract void CookIngredient();
    

    private void OnMouseDown()
    {
        if (GameManager.instance.gameState.inventory == null)
        {
            Inventory();   
        }
    }

    protected abstract Commands getCommand();

}
