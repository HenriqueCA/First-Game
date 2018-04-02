using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float slowDown = 10f;

    public GameObject MainCamera;
    public GameObject TopCamera;

    public static int deathCount;

    public GameObject pauseMenu;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            StartCoroutine(Restart());
            deathCount++;
        }

    }

    IEnumerator Restart()
    {
        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;

        MainCamera.SetActive(false);
        TopCamera.SetActive(true);
        yield return new WaitForSeconds(1f / slowDown);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;

        MainCamera.SetActive(true);
        TopCamera.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
