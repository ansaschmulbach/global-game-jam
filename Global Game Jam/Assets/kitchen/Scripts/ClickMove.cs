using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public Vector3 target;
    private float step = 0.0f;

    public void setTargetToPointer(){
        Debug.Log("Clicked");
        Debug.Log(Input.mousePosition);
        this.target = Input.mousePosition;
    }

    void Awake()
    {
        Debug.Log("Hello!");
        this.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.step = this.speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.target, step);
    }
}
