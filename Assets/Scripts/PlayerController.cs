using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject gameStateManager;
    public new Rigidbody rigidbody;

    private bool touchingGround; 
    public int sidewardsForce;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameStateManager = GameObject.Find("GlobalStateManager");
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = gameStateManager.GetComponent<GlobalStateManager>().gameOver;

        GetKey();
    }

    private void GetKey()
    {
        if (Input.GetKey(KeyCode.D) && !isGameOver && touchingGround)
        {
            rigidbody.AddForce(sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A) && !isGameOver && touchingGround)
        {
            rigidbody.AddForce(-sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Floor") {
            touchingGround = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag == "Floor") {
            touchingGround = false;
        }
    }
}
