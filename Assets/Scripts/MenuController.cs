using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Text HighscoreNickname;
    public Text Highscore;

    private void Start()
    {
        LoadHighscore();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    private void LoadHighscore()
    {
        var nickname = PlayerPrefs.GetString("HighscoreNickname");
        var score = PlayerPrefs.GetInt("Highscore");

        if (nickname.Length > 0)
        {
            HighscoreNickname.text = nickname + ":\t ";
            Highscore.text = score.ToString();
        }
        else
        {
            HighscoreNickname.text = "---:\t ";
            Highscore.text = "---";
        }
    }
}