using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Touchable"))
        {
            AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }
}

