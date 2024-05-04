using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            int damage = 10;
            GetComponent<Health>().TakeDamage(damage);
        }
    }
}
