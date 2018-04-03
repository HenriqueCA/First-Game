using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{

    public void Adjust(Scrollbar scrollBar)
    {
        GameObject.FindObjectOfType<AudioManager>().changeVolume(scrollBar.value);
    }
}
