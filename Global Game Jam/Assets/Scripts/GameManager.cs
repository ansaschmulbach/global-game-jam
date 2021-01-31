using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameState gameState = new GameState();

    void Awake()
    {
        if (GameManager.instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadPantry()
    {
        
    }

    public void LoadKitchen()
    {
        SceneManager.LoadScene("Cooking Test");
    }
    
}
