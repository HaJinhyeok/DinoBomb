using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager s_instance = null;
    public static GameManager Instance
    {
        get
        {
            if(s_instance == null)
                return null;
            else return s_instance;
        }
    }

    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public Text ScoreText;

    int _score = 0;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

}
