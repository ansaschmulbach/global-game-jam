using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera camera;
    private Transform player;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [SerializeField] private float dampTime = 0.15f;
    [SerializeField] private Vector2 vectorDelta;
    
    void Start()
    {
        camera = GetComponent<Camera>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        this.player = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            Vector3 point = camera.WorldToViewportPoint(player.position);
            Vector3 delta = player.position - camera.ViewportToWorldPoint(new
                Vector3(0, 0, point.z));
            Vector3 dest = this.transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, dest, ref velocity, dampTime);
        }
    }
}
