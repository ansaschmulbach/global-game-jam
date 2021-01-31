using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantryPlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(xSpeed, ySpeed);
        this.transform.position += direction * (Time.deltaTime * speed);

    }
}
