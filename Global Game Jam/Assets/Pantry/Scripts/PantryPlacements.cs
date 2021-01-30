using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantryPlacements : MonoBehaviour
{
    public GameObject shelf1;
    public GameObject shelf2;
    public GameObject Background;

    // Start is called before the first frame update
    void Start()
    {

        GameObject firstShelf = Instantiate(shelf1, new Vector3(0, 0, 0), Quaternion.identity);
        firstShelf.transform.SetParent(Background.transform, false);

        for (var i = 0; i < 2; i++)
        {
            GameObject shelfTwo = Instantiate(shelf2, new Vector3(0, 0, 0), Quaternion.identity);
            shelfTwo.transform.SetParent(Background.transform, false);
            GameObject shelfOne = Instantiate(shelf1, new Vector3(0, 0, 0), Quaternion.identity);
            shelfOne.transform.SetParent(Background.transform, false);
        }
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
