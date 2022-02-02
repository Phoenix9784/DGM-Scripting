using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,2,-4);

    // Update is called once per frame
    void Update()
    {
        //Match the camera's position to follow the player
        transform.position = player.transform.position + offset;
    }
}
