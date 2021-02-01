using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip[] songs;

    // Start is called before the first frame update
    void Start()
    {
        playSong1();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSong1()
    {
        AS.clip = songs[0];
        AS.Play();
    }

    public void playSong2()
    {
        AS.clip = songs[1];
        AS.Play();
    }
}
