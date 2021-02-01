using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public abstract class Ingredient : MonoBehaviour
{
    public bool cooked = false;
    public int pointsEarned = 0;
    public List<Commands> validCommands;
    private float downClickTime;
    private float ClickDeltaTime = 0.2F;

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
            }

            if (this.name.Equals(step.ingredient.name))
            {
                pointsEarned += (int)(GameState.PointsPer * 0.5f);
            }
            
        }
    }

    public abstract string GetRecipeLine();
    protected abstract void CookIngredient();
<<<<<<< HEAD
=======

>>>>>>> 4d276e8af3066fb545db2d70f24609b524c74232

    private void OnMouseUp()
    {
        Console.WriteLine("hi");
        if (Time.time - downClickTime <= ClickDeltaTime)
        {
<<<<<<< HEAD
            if (GameManager.instance.gameState.inventory == null)
            {
                Inventory();
            }

        }
    }
    

    private void OnMouseDown()
    {
        downClickTime = Time.time;
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }

    /*
     * private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

    }
     */


=======
            Inventory();
        }
    }
    
>>>>>>> 4d276e8af3066fb545db2d70f24609b524c74232

    protected abstract Commands getCommand();

}