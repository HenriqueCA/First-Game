using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    public Text scoreCounter;

    public Score scoreScript;
    static int bestScore = 0;

    // Use this for initialization
    void Start()
    {
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
        }
    }
}
