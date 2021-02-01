using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewDialogue : MonoBehaviour
{
    [SerializeField] private List<string> dialogueText;
    private int index;
    private int changeIndex;
    [SerializeField] private List<bool> changed;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<int> spriteInts;
    [SerializeField] private int change;
    [SerializeField] private Text dialogueBox;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite newSprite;
    public string nextScene;
    
    void changeSprite(int i) {
        spriteRenderer.sprite = sprites[i];
    }

    void Start() {
        index = 0;
        changeIndex = 0;
        dialogueBox.text = dialogueText[index];    
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            index++;
            if(index == dialogueText.Count)
            {
                SceneManager.LoadScene(nextScene);
            } 
            changeSprite(spriteInts[index]);
            // if(changed[index]) {
            //     changeSprite(spriteInts[changeIndex]);
            //     changeIndex++;
            // }
            dialogueBox.text = dialogueText[index];
        }
    }
}
