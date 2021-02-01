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
    float doneTime = 5f;
    private bool burned;
    private bool isDone;
    
    private SpriteRenderer spriteR;
    public Sprite wellDoneImg;

    public override string GetRecipeLine()
    {
        return "Fry a " + name;
    }


    void Start()
    {
        this.spriteR = GetComponent<SpriteRenderer>(); 
    }

    protected override void CookIngredient()
    {
        Debug.Log("You catch more FRYs with honey :P");
        this.spriteR.sprite = wellDoneImg;
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
            this.spriteR.sprite = wellDoneImg;
        }
    }

    protected override Commands getCommand()
    {
        return Commands.Stirfry;
    }

}
