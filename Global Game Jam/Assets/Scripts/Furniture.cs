using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{

    private bool isSelected;
    private SpriteRenderer spriteRenderer;
    private GameManager gm;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gm = GameManager.instance;
    }
    
    public virtual void Select()
    {
        GameObject inv = gm.gameState.inventory;
        if (inv != null && inv.TryGetComponent(out Ingredient ingredient) && !ingredient.cooked)
        {
            Vector3 pos = this.transform.position + offset;
            inv.transform.position = pos;
            inv.GetComponent<SpriteRenderer>().enabled = true;
            
            if (gm.gameState.selectedFurniture != null)
            {
                gm.gameState.selectedFurniture.Deselect();
            }

            gm.gameState.selectedFurniture = this;
            isSelected = true;
            spriteRenderer.color = Color.gray;
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
