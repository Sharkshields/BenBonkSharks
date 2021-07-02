using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audio;

    public void StartAudio()
    {
        audio.Play();
    }

    public void PauseAudio()
    {
        audio.Pause();
    }

    public void StopAudio()
    {
        audio.Stop();
    }
}
