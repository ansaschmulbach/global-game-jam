using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fryable : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeOfFry;
    private float burnTime = 10.5f;
    private bool burned; 
    private SpriteRenderer spriteR;
    void Start()
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
            this.spriteR.color = Color.black;
        }
    }

    bool isBurned(){
        return timeOfFry > burnTime;
    }
}
