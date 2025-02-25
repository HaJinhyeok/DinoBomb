using UnityEngine;
using UnityEngine.UI;

public class UI_Result : MonoBehaviour
{
    public Button RestartButton;
    public Text ScoreText;

    void Start()
    {
        RestartButton.onClick.AddListener(OnRestartButtonClick);
        ScoreText.text = $"SCORE\n{GameManager.Instance.Score}";
    }

    void OnRestartButtonClick()
    {
        GameManager.Instance.Score -= GameManager.Instance.Score;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
