using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakeable : Ingredient
{
    
    private SpriteRenderer spriteR;
    
    void Start()
    {
        this.spriteR = GetComponent<SpriteRenderer>();
    }
    protected override Commands getCommand()
    {
        return Commands.OVEN;
    }

    protected override void CookIngredient()
    {
        this.spriteR.color = Color.magenta;
    }

    public override string GetRecipeLine()
    {
        return "Bake a " + name;
    }
}
