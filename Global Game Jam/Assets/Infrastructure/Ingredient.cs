using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ingredient : MonoBehaviour
{

    void Trash()
    {
        Destroy(this.gameObject);
    }

    void Inventory()
    {
        GameManager.instance.gameState.inventory = this;
    }

    protected abstract string GetRecipeLine();
    protected abstract void Cook();
    
}
