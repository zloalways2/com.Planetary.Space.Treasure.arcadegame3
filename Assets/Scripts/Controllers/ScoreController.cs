using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _scoreText;

    private int points = 0;
    
    private void Start()
    {
        UpdateScoreText();
    }

    public void AddPoints(int amount)
    {
        points += amount;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (_scoreText != null)
        {
            for (int i = 0; i < _scoreText.Length; i++)
            {
                _scoreText[i].text = "Points: " + points.ToString("D3");
            }
            
        }
    }
}