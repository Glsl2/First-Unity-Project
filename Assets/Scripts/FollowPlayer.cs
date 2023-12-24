using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Gets player position
    public Transform playerPos;

    // The offest and rotation of the camera related to player
    public Vector3 offset;
    public Vector3 rotation;

    void Start()
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(playerPos.position + offset, Quaternion.Euler(rotation));
    }
}
