using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fryMinigame : MonoBehaviour
{
    // Start is called before the first frame update
    public fryable[] fryables;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < fryables.Length; i ++){
            fryables[i].UpdateCookTime();
        } 
    }
}
