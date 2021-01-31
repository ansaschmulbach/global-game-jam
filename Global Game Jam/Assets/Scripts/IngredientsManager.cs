using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsManager : MonoBehaviour
{

    public List<GameObject> ingredientsPrefabs;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

}
