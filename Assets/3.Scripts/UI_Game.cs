using UnityEngine;
using UnityEngine.UI;

public class UI_Game : MonoBehaviour
{
    public Text ScoreText;

    float _coolTime = 0f;
    const float _scoreInterval = 1.5f;

    void Start()
    {
        ScoreText.text = GameManager.Instance.Score.ToString();
    }

    void Update()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Game")
        {
            _coolTime += Time.deltaTime;
            if (_coolTime > _scoreInterval)
            {
                _coolTime = 0f;
                GameManager.Instance.Score++;
                ScoreText.text = GameManager.Instance.Score.ToString();
            }
        }
    }
}
