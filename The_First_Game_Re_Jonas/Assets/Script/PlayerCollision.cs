using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public add movement;
    public add movement2;
    public add movement3;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            movement2.enabled = false;
            movement3.enabled = false;
        }
    }
}
