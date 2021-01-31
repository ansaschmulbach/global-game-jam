using System;
using System.Text;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsPlacement : MonoBehaviour
{
    [SerializeField] public List<GameObject> ingredients;
    public GameObject pantryFrame;
    public GameObject tempIngredient;
    public System.Random random = new System.Random();
    private static System.Timers.Timer timer;
    private int height = 750;
    private int width = 1210;

    private int low = 100;
    private int high = 1210 - 100;
    private List<GameObject> instIngredients;

    // Start is called before the first frame update

    void Start()
    {
        /*
        int height = 750;
        int width = 1210;
       
        int low = 100;
        int high = width-100;
         */

        int rand = random.Next(low, high);
 
        for(int i = 0; i < 5; i ++)// shelves
        {
            for(int j = 0; j < 10; j ++) {//ingredients
                rand = random.Next(low, high);
                GameObject ingredient = Instantiate(tempIngredient, new Vector3(rand, -i*127-75, 0), Quaternion.identity);
                ingredient.transform.SetParent(pantryFrame.transform, false);
                instIngredients.Add(ingredient);
            }
            
        }

        for(int j = 0; j < 10; j ++) {//last shelf
                rand = random.Next(low, high);
                GameObject ingredient = Instantiate(tempIngredient, new Vector3(rand, -5*127-50, 0), Quaternion.identity);
                ingredient.transform.SetParent(pantryFrame.transform, false);
                instIngredients.Add(ingredient);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        int rand = random.Next(1, 10000);
        int randNum = random.Next(low, high);
        int shelfNum = 1;
        int count = 0;
        if (rand == 20)
        {

           foreach(GameObject i in instIngredients)
            {
                if (count >= 10)
                {
                    count = 0;
                    shelfNum++;
                }
                //update position
                i.transform.position = new Vector3(randNum, -shelfNum * 127 - 75, 0);
                count++;

            }




        }

    }
}
