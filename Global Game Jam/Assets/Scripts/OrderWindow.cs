using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderWindow : Furniture
{
    public override void Select()
    {
        GameObject inv = GameManager.instance.gameState.inventory;
        if (inv != null)
        {
            Ingredient[] ings = inv.GetComponents<Ingredient>();
            bool flag = false;
            foreach (Ingredient ing in ings)
            {
                flag = flag || ing.cooked;
            }
            
            if (flag)
            {
                Collect(inv);
            }
        } 
        
        if (GameManager.instance.gameState.selectedFurniture != null)
        {
            GameManager.instance.gameState.selectedFurniture.Deselect();
        }
    }

    public void Collect(GameObject inv)
    {
        GameState gs = GameManager.instance.gameState;
        gs.points += gs.inventory.GetComponent<Ingredient>().pointsEarned;
        Recipe.nextStep();
        Destroy(inv);
    }
    
}
