using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    public Text scoreCounter;

    public Score scoreScript;
    int bestScore;

    // Use this for initialization
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
        scoreCounter.text = bestScore.ToString();
    }

    void Update()
    {
        NewScore();
    }

    void NewScore()
    {
        if (scoreScript.score > bestScore)
        {
            bestScore = scoreScript.score;
            PlayerPrefs.SetInt("bestScore", bestScore);
        }
    }
}
