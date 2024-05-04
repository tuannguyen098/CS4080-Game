using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Health playerHealth;
    private Image healthBar;

    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    void Update()
    {
        if (playerHealth != null)
        {
            healthBar.fillAmount = (float)playerHealth.currentHealth / playerHealth.maxHealth;
        }
    }
}
