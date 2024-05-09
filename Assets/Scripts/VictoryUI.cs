using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryUI : MonoBehaviour
{
    public GameObject victoryPanel;

    void Start()
    {
        victoryPanel.SetActive(false);
    }

    public void ToggleVictory(bool isShown)
    {
        victoryPanel.SetActive(isShown);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
