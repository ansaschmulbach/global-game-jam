using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Ingredient : MonoBehaviour
{

    
    /** DEBUGGING PURPOSES ONLY **/
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Cook();
        } else if (Input.GetKeyDown("t"))
        {
            Trash();
        } else if (Input.GetKeyDown("i"))
        {
            Inventory();
            //Debug.Log(GameManager.instance.gameState.inventory.GetRecipeLine());
        }
    }
    
    void Trash()
    {
        Destroy(this.gameObject);
    }

    void Inventory()
    {
        GameManager.instance.gameState.inventory = this.gameObject;
        GetComponent<SpriteRenderer>().enabled = false;
    }

    public abstract string GetRecipeLine();
    public abstract void Cook();
    
}
