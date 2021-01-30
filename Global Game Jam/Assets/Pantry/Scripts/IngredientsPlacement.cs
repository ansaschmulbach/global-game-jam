using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsPlacement : MonoBehaviour
{
    [SerializeField] public List<GameObject> ingredients;
    public GameObject frame;
    public GameObject pantryFrame;
    public System.Random random = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        int height = 1210 ;
        int width = 750;
       
        int low = (0 - width)/2;
        int high = width / 2;
        int rand = random.Next(low, high);
        foreach (GameObject i in ingredients)
        {
            rand = random.Next(low, high);
            GameObject ingredient = Instantiate(i, new Vector3(rand, 0, 0), Quaternion.identity);
            ingredient.transform.SetParent(pantryFrame.transform, false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


