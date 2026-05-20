using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int score;
    public int health;
    public Text scoreText;
    public Text healthText;  // ← new

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            health--;
            // Debug.Log(health);
            SetHealthText();  // ← new
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
}