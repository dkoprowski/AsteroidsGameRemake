using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsController : MonoBehaviour {
    public int Lives;
    public int Points;
    public Text PointsText;
    public Text LivesText;

	void Start () {
        Lives = 3;
        Points = 0;
        UpdateText();
	}
	
    public void RemoveLife()
    {
        Lives--;
        UpdateText();
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
}
