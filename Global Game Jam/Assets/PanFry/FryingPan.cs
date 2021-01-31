using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditorInternal;
#endif

using UnityEngine;

public class FryingPan : Utensil 
{
    // Start is called before the first frame update
    private Fryable item;

    public override bool Cook(GameObject inv)
    {
        if (inv.TryGetComponent(out Fryable fry))
        {
            this.item = fry;
            fry.Cook();
            return true;
        }

        return false;
    }
    
    void Update(){
        if(item != null){
            item.UpdateCookTime();
        }
    }

}
