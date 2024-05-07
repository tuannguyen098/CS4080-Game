using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameManager gameManager;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        GetComponent<PlayerController>().enabled = false;
        gameManager.EndGame();
    }
}