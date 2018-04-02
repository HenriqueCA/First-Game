using UnityEngine;
using UnityEngine.UI;
public class DeathCounter : MonoBehaviour
{
    public Text text;

    // Use this for initialization
    void Start()
    {
        text.text = GameManager.deathCount.ToString();
    }

}
