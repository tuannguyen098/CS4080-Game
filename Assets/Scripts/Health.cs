using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameOverUI gameOverUI;

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
        EndGame();
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        if(gameOverUI != null )
        {
            gameOverUI.ToggleGameOver(true);
        }
    }
}