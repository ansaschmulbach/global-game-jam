using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoppingBoard : Utensil
{
    
    public override bool Cook(GameObject inv)
    {
        if (inv.TryGetComponent(out Choppable chop))
        {
            chop.Cook();
            return true;
        }

        return false;
    }
    
}
