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
            Ingredient ing = inv.GetComponent<Ingredient>();
            if (ing.cooked)
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
        GameManager.instance.gameState.points += 10;
        Debug.Log(GameManager.instance.gameState.points);
        Destroy(inv);
    }
    
}
