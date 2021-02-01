using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayInventory : MonoBehaviour
{
    [SerializeField]
    public Image image;
    //private Image m_Image;
    //Set this in the Inspector
    

    void Start()
    {
        //Fetch the Image from the GameObject
        //m_Image = GetComponent<Image>();
    }

    void Update()
    {
        image.sprite = GameManager.instance.gameState.inventory.GetComponent<SpriteRenderer>().sprite;
        
    }
}
