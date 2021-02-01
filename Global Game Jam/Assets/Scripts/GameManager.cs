using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameState gameState = new GameState();
    public MusicManager jukebox;

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

    public void LoadPantry()
    {
        SceneManager.LoadScene("Pantry");
    }

    public void LoadKitchen()
    {
        SceneManager.LoadScene("Kitchen");
    }
    
    public void cookingSong() //Cue the song that plays while you're cooking
    {
        jukebox.playSong1();
    }

    public void chillSong() //Cue the song that plays in dialogue
    {
        jukebox.playSong2();
    }
}
