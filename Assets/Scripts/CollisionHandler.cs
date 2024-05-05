using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision collision)
    {
        PlayerController controller = GetComponent<PlayerController>();
        Debug.Log(collision.collider.name);
        if (collision.collider.CompareTag("Obstacle"))
        {
            int damage = 10;
            GetComponent<Health>().TakeDamage(damage);
            controller.isCrashed(true);
        }
        else if (collision.collider.CompareTag("Car"))
        {
            int damage = 15;
            GetComponent<Health>().TakeDamage(damage);
            controller.isCrashed(true);
        }
        else if (collision.collider.CompareTag("Bus"))
        {
            int damage = 20;
            GetComponent<Health>().TakeDamage(damage);
            controller.isCrashed(true);
        }
       
        
        
       
    }
}
