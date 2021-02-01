using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public abstract class Ingredient : MonoBehaviour
{
    public bool cooked = false;
    public int pointsEarned = 0;
    public List<Commands> validCommands;

    void Trash()
    {
        Destroy(this.gameObject);
    }

    public void Inventory()
    {
        GameManager.instance.gameState.inventory = this.gameObject;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;
        Debug.Log(GetComponent<Rigidbody2D>().isKinematic);
        DontDestroyOnLoad(this.gameObject);
    }

    void Deinventory()
    {
        Destroy(this.gameObject);
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
                Debug.Log("Gained cook points!");
            }

            if (name.Equals(step.ingredient.name) || (name).Equals(step.ingredient.name + "(Clone)"))
            {
                pointsEarned += (int)(GameState.PointsPer * 0.5f);
                Debug.Log("Gained name points!");
            }
            else
            {
                Debug.Log(name + ", " + step.ingredient.name);
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