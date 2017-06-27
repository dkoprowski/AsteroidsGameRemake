using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PointsController : MonoBehaviour
{
    public int Lives;
    public int Points;
    public Text PointsText;
    public Text LivesText;

    public Canvas FinishGameCanvas;
    public PlayerBehav PlayerBehav;
    public InputField NicknameInput;
    public Text Warning;
    public Text FinishPointsText;

    private void Start()
    {
        FinishGameCanvas.gameObject.SetActive(false);
        Warning.gameObject.SetActive(false);

        Lives = 3;
        Points = 0;
        UpdateText();
    }

    public void RemoveLife()
    {
        Lives--;
        UpdateText();

        if (Lives <= 0)
        {
            FinishGame();
        }
    }

    public void AddPoint()
    {
        Points++;
        UpdateText();
    }

    public void UpdateText()
    {
        PointsText.text = "Points:\t" + Points;
        LivesText.text = "Lives:\t" + Lives;
    }

    private void FinishGame()
    {
        PlayerBehav.DisablePlayer();
        FinishPointsText.text = Points.ToString();
        FinishGameCanvas.gameObject.SetActive(true);
    }

    public void SaveScores()
    {
        if (NicknameInput.text.Length > 0)
        {
            if (PlayerPrefs.GetInt("Highscore", 0) < Points)
            {
                PlayerPrefs.SetString("HighscoreNickname", NicknameInput.text);
                PlayerPrefs.SetInt("Highscore", Points);
            }

            SceneManager.LoadScene(0);
        }
        else
        {
            Warning.gameObject.SetActive(true);
        }
    }
}