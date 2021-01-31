using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choppable : Ingredient
{
    
    [SerializeField] private string name;
    private SpriteRenderer spriteR;

    void Start()
    {
        this.spriteR = GetComponent<SpriteRenderer>();
    }

    public override string GetRecipeLine()
    {
        return "Chop a " + name;
    }

    /** DEBUGGING PURPOSES ONLY **/
    protected override void CookIngredient()
    {
        this.spriteR.color = Color.red;
        
    }
}
