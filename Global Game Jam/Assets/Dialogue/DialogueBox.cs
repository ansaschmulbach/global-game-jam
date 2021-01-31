using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] private List<string> dialogueText;
    private int index;
    [SerializeField] private int change;
    [SerializeField] private Text dialogueBox;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite newSprite;
    
    void changeSprite() {
        spriteRenderer.sprite = newSprite;
    }

    void Start() {
        index = 0;
        dialogueBox.text = dialogueText[index];    
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            index++;
            if(index == dialogueText.Count)
            {
                return;
            } 
            if(index == change) {
                changeSprite();
            }
            dialogueBox.text = dialogueText[index];
        }
    }
    void rand() {
        System.Random random = new System.Random();
        int randomInt = random.Next(1, 100);
    }
}
