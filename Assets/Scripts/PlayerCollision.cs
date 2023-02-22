using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if ( collisionInfo.gameObject.tag == "Obstacle" ) {
            Debug.Log("Obstacle collision");
            movement.enabled = false;
        }
    }
}
