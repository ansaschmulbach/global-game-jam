﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager manager;

    void Awake()
    {
        this.manager = GetComponent<GameManager>();
    }

    public void GoToKitchen()
    {
        GameManager.instance.LoadKitchen();
    }
    public void GoToPantry(){
        GameManager.instance.LoadPantry();
    }
    
    // public void HAYO()
    // {
    //     print("HAYO");
    // }
}
