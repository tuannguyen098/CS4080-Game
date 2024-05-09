

using UnityEngine;


public class GameManager: MonoBehaviour{
    public GameOverUI gameOverUI;
    public VictoryUI victoryUI;
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

    public void Victory()
    {
        Debug.Log("Victory!");
        if (victoryUI != null)
        {
            timer.StopTimer();
            victoryUI.ToggleVictory(true);
        }
    }
}