using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsPlacement : MonoBehaviour
{
    [SerializeField] public List<GameObject> ingredients;
    public GameObject pantryFrame;
    public GameObject tempIngredient;
    public System.Random random = new System.Random();


    // Start is called before the first frame update

    void Start()
    {
        int height = 750;
        int width = 1210;
       
        int low = 100;
        int high = width-100;
        int rand = random.Next(low, high);
        

        //foreach (GameObject i in ingredients)
        for(int i = 0; i < 5; i ++)// shelves
        {
            for(int j = 0; j < 10; j ++) {//ingredients
                rand = random.Next(low, high);
                GameObject ingredient = Instantiate(tempIngredient, new Vector3(rand, -i*127-75, 0), Quaternion.identity);
                ingredient.transform.SetParent(pantryFrame.transform, false);
            }
            
        }

        for(int j = 0; j < 10; j ++) {//last shelf
                rand = random.Next(low, high);
                GameObject ingredient = Instantiate(tempIngredient, new Vector3(rand, -5*127-50, 0), Quaternion.identity);
                ingredient.transform.SetParent(pantryFrame.transform, false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
