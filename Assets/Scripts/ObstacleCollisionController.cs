using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private GameObject gameStateManager;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        gameStateManager = GameObject.Find("GlobalStateManager");
        rb.AddForce(Vector3.back * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            var script = gameStateManager.GetComponent<GlobalStateManager>();
            script.gameOver = true;
        }
    }
}
