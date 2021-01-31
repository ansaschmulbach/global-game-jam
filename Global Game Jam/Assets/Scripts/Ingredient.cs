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
    
    /** DEBUGGING PURPOSES ONLY **/
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Cook();
        } else if (Input.GetKeyDown("t"))
        {
            Trash();
        } else if (Input.GetKeyDown("i"))
        {
            Inventory();
            //Debug.Log(GameManager.instance.gameState.inventory.GetRecipeLine());
        }
    }
    
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
            if (getCommand() == step.command)
            {
                pointsEarned += (int)(GameState.PointsPer * 0.5f);
            }

            if (this == step.ingredient)
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
