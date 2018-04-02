using UnityEngine.SceneManagement;
using UnityEngine;

public class Welcome : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
