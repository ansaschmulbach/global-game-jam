
using System;
using UnityEngine;

public abstract class Utensil : MonoBehaviour
{
    private GameManager gm;
    private Furniture parent;
    public GameObject ing;
    
    void Start()
    {
        gm = GameManager.instance;
        parent = GetComponentInParent<Furniture>();
    }
    
    public bool Use()
    {
        GameObject inv = gm.gameState.inventory;
        if (inv.TryGetComponent(out Ingredient ing) && !ing.cooked && Cook(inv))
        {
            gm.gameState.inventory = null;
            return true;
        }

        return false;
    }

    public abstract bool Cook(GameObject inv);

    private void OnMouseDown()
    {
        if (parent.IsSelected() && gm.gameState.inventory && Use())
        {
        }
        else if (ing != null)
        {
            Ingredient ingredient = ing.GetComponent<Ingredient>();
           ingredient.Inventory();
        }
    }
}