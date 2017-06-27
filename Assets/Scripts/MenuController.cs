using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using Consts;

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
        SceneManager.LoadScene(Scenes.Main);
    }

    private void LoadHighscore()
    {
        var nickname = PlayerPrefs.GetString(Prefs.Nickname);
        var score = PlayerPrefs.GetInt(Prefs.Score);

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