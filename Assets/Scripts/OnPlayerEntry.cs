using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerEntry : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 offset;

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if ( other.name == "Player" ) {
            GameObject newSurface = Instantiate(prefab, Vector3.forward + transform.position + offset, Quaternion.identity);
            Debug.Log("Player Detected!");
        }
    }
}
