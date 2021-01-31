using System.Collections;
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
        print("To Kitchen!");
        GameManager.instance.LoadKitchen();
    }
    
    // public void HAYO()
    // {
    //     print("HAYO");
    // }
}
