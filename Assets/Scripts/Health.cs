using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameOverUI gameOverUI;
    public Timer timer;

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
            timer.StopTimer();
            gameOverUI.ToggleGameOver(true);
        }
    }
}