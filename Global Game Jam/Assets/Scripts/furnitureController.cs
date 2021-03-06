﻿using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditorInternal;
#endif
using UnityEngine;


public class furnitureController : MonoBehaviour
{
    public ClickMove player;
    private Furniture furniture;
    public Vector3 offset;

    void Start()
    {
        furniture = GetComponent<Furniture>();
        player = GameObject.FindWithTag("Player").GetComponent<ClickMove>();
    }
    
    public void setPlayerTarget(){
        Vector3 pos = this.transform.position;
        player.target = new Vector3(pos.x + offset.x, player.transform.position.y + offset.y, 
            player.transform.position.z + offset.z);
        player.setAnimator();
    }

    void OnMouseDown(){
        setPlayerTarget();
        furniture.Select();
    }


}