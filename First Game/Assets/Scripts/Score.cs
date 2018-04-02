using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public int score;

    float timeStart;

    void Start()
    {
        timeStart = Time.time;

    }


    // Update is called once per frame
    void Update()
    {

        if (Time.time - timeStart >= 1f)
        {
            addScore();
            scoreText.text = score.ToString();
            timeStart = Time.time;
        }

    }

    void addScore()
    {
        score++;
    }
}
