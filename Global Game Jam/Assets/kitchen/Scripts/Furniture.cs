using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{

    private bool isSelected;
    private SpriteRenderer spriteRenderer;
    private GameState gs;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gs = GameManager.instance.gameState;
    }
    
    public void Select()
    {
        if (gs.selectedFurniture != null)
        {
            gs.selectedFurniture.Deselect();
        }

        gs.selectedFurniture = this;
        isSelected = true;
        spriteRenderer.color = Color.gray;
        
        GameObject inv = gs.inventory;
        if (inv.TryGetComponent(out Ingredient ingredient))
        {
            Vector3 pos = this.transform.position + offset;
            inv.transform.position = pos;
            inv.GetComponent<SpriteRenderer>().enabled = true;
        }
        
    }

    public void Deselect()
    {
        isSelected = false;
        spriteRenderer.color = Color.white;
    }

    public bool IsSelected()
    {
        return isSelected;
    }
}
