
using System;
using UnityEngine;

public class Utensil : MonoBehaviour
{
    private GameManager gm;
    private Furniture parent;
    private Ingredient ing;
    
    void Start()
    {
        gm = GameManager.instance;
        parent = GetComponentInParent<Furniture>();
    }
    
    public void Cook()
    {
        GameObject inv = gm.gameState.inventory;
        if (inv.TryGetComponent(out Choppable chop))
        {
            chop.Cook();
            gm.gameState.inventory = null;
        }
    }

    private void OnMouseDown()
    {
        if (parent.IsSelected())
        {
            Cook();
        }
    }
}