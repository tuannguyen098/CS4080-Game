

using UnityEngine;


public class GameManager: MonoBehaviour{
    public GameOverUI gameOverUI;
    public Timer timer;

    public void EndGame()
    {
        Debug.Log("Game Over!");
        if (gameOverUI != null)
        {
            timer.StopTimer();
            gameOverUI.ToggleGameOver(true);
        }
    }
}