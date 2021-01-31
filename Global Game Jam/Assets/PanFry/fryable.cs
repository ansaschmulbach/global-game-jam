using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditorInternal;
#endif

public class Fryable : Ingredient
{
    // Start is called before the first frame update
    private float timeOfFry;
    private float burnTime = 10.5f;
    private float doneTime = 5f;
    private bool burned;
    private bool isDone;
    private SpriteRenderer spriteR;
    [SerializeField] private string name;

    public override string GetRecipeLine()
    {
        return "Fry a " + name;
    }

    protected override void CookIngredient()
    {
        timeOfFry = 0.0f;
        this.spriteR = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    public void UpdateCookTime()
    {
        timeOfFry += Time.deltaTime;

        if (timeOfFry > burnTime && !burned) {
            burned = true; 
            isDone = false;
            this.spriteR.color = Color.black;
        } else if (timeOfFry > doneTime && timeOfFry < burnTime){
            isDone = true;
            this.spriteR.color = new Color(222f, 183f, 0f, 1f);
        }
    }

    bool isBurned(){
        return timeOfFry > burnTime;
    }


}
