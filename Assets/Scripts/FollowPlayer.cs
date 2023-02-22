using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Gets player position
    public Transform playerPos;
    // The offest of the camera related to player
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + offset;
    }
}
