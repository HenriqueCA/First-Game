using UnityEngine.Audio;
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
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
        }
    }


}
