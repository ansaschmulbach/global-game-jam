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
    // void Start(int height, int width)
    // {
    //     int low = (0 - width)/2;
    //     int hight = width / 2;
    //
    //     int x = 0;
    //     foreach (int i in ingredients)
    //     {
    //         x = random.Next(low, high);
    //         GameObject ingredient = Instantiate(i, new Vector3(x, 0, 0), Quaternion.identity);
    //         ingredient.transform.SetParent(Background.transform, false);
    //     }
    //     
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}


