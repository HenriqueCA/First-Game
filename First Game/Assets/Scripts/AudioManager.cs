using UnityEngine.Audio;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static float volumeMaster = 1f;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = volumeMaster;
            s.source.pitch = s.pitch;
        }

        StartCoroutine(PlayAll());

    }

    IEnumerator PlayAll()
    {
        while (true)
        {
            for (int i = 0; i < sounds.Length; i++)
            {
                sounds[i].source.Play();
                yield return new WaitForSeconds(sounds[i].source.clip.length);
            }
        }
    }

    public void changeVolume(float volume)
    {
        foreach (Sound s in sounds)
        {
            s.source.volume = volume;
            volumeMaster = volume;
        }
    }


}
