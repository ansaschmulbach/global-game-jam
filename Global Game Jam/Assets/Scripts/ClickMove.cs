using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public Vector3 target;
    private float step = 0.0f;
    private Animator playerAnimator;

    public void setAnimator(){
		//playerAnimator.SetFloat("speed", Mathf.Abs(this.speed));
    }

    void Awake()
    {
        this.playerAnimator = GetComponent<Animator>();
        this.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.step = this.speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.target, step);
        float mSpeed = Input.GetAxis("Horizontal");

        float distance = (this.transform.position - target).x;
        playerAnimator.SetFloat("speed", Mathf.Abs(distance));

        if(distance < 0){
            transform.localScale = new Vector2(-1.0f, 1.0f);
        } else {
            transform.localScale = new Vector2(1.0f, 1.0f);
        }
    }
}
