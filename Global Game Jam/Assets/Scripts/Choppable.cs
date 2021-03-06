﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choppable : Ingredient
{
    
    private SpriteRenderer spriteR;
    public Sprite chopped;

    void Start()
    {
        this.spriteR = this.GetComponent<SpriteRenderer>();
    }

    public override string GetRecipeLine()
    {
        return "Chop a " + name;
    }

    /** DEBUGGING PURPOSES ONLY **/
    protected override void CookIngredient()
    {
        this.spriteR.sprite = chopped;
    }

    protected override Commands getCommand()
    {
        return Commands.Chop;
    }
}
