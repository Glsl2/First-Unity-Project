using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 900f;
    public float sidewardsForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        Debug.Log(rb.velocity);
    }
}
