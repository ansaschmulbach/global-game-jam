using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chop : Ingredient
{

    [SerializeField] private string name;
    
    protected override string GetRecipeLine()
    {
        return "Chop a " + name;
    }

    protected override void Cook()
    {
        //script to chop an item
    }
}
