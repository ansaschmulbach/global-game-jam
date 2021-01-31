using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditorInternal;
#endif

using UnityEngine;

public class clickStove : MonoBehaviour
{
    // Start is called before the first frame update
    private fryable item;
    public fryable pan;

    void OnMouseDown(){
        // WHAT DO?
        Debug.Log("Clicked Stove!");
        if(item != null){
            DestroyImmediate(item);
        } else {
            item = Instantiate(pan, this.transform.position, Quaternion.identity);
        }
    }
    void Update(){
        if(item != null){
            item.UpdateCookTime();
        }
    }

}
