using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float smoothSpeed = 1f;
        
    void start()

{
    player = GameObject.FindGameObjectWithTag("Player").transform;
}


     void FixedUpdate()
    {
        Vector3 startPosition  = new Vector3(player.position.x, player.position.y, -1f);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, startPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
