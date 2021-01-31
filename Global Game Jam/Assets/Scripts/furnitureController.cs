using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditorInternal;
#endif
using UnityEngine;


public class furnitureController : MonoBehaviour
{
    public ClickMove player;
    private Furniture furniture;

    void Start()
    {
        furniture = GetComponent<Furniture>();
    }
    
    public void setPlayerTarget(){
        Debug.Log("Clicked");
        Vector3 pos = this.transform.position;
        player.target = new Vector3(pos.x, player.transform.position.y, player.transform.position.z);
    }

    void OnMouseDown(){
        setPlayerTarget();
        furniture.Select();
    }


}