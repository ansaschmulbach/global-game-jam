using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDragDrop : MonoBehaviour
{
    private bool dragging;
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        dragging = false;
        canvas = GetComponentInParent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            FollowMouse();
        }   
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
            dragging = false;

    }

    /*
     * Credit to @troien on Unity forums for this method
     */
    void FollowMouse()
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, 
            Input.mousePosition, canvas.worldCamera, out pos);
        transform.position = canvas.transform.TransformPoint(pos);
    }

    public void BeginDrag()
    {
        dragging = true;
    }

    public void EndDrag()
    {
        dragging = false;
    }

    public void Inventory()
    {
        if (!dragging)
        {
            Destroy(this.gameObject);
        }
    }
    
}
