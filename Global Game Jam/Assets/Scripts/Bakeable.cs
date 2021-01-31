using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakeable : Ingredient
{
    
    private SpriteRenderer spriteR;
    public Sprite bakedImage;
    
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
        this.spriteR.sprite= bakedImage;
    }

    public override string GetRecipeLine()
    {
        return "Bake a " + name;
    }
}
