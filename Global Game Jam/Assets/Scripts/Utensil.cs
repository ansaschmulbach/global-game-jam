
using System;
using UnityEngine;

public abstract class Utensil : MonoBehaviour
{
    private GameManager gm;
    private Furniture parent;
    private Ingredient ing;
    
    void Start()
    {
        gm = GameManager.instance;
        parent = GetComponentInParent<Furniture>();
    }
    
    public void Use()
    {
        GameObject inv = gm.gameState.inventory;
        if (inv.TryGetComponent(out Ingredient ing) && !ing.cooked && Cook(inv))
        {
            gm.gameState.inventory = null;
        }
    }

    public abstract bool Cook(GameObject inv);

    private void OnMouseDown()
    {
        if (parent.IsSelected() && gm.gameState.inventory)
        {
            Use();
        }
    }
}