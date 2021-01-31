using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : Furniture
{
    public override void Select()
    {
        if (GameManager.instance.gameState.inventory != null)
        {
            Destroy(GameManager.instance.gameState.inventory);
        }
        if (GameManager.instance.gameState.selectedFurniture != null)
        {
            GameManager.instance.gameState.selectedFurniture.Deselect();
        }
    }
}
