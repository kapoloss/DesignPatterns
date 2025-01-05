using UnityEngine;

namespace DesignPattern.Structural.AdapterPattern.ExampleUsage;

public class UnityAudioPlayer : IAudioPlayer
{
    private AudioSource _audioSource;

    public UnityAudioPlayer()
    {
        _audioSource = new AudioSource();
    }

    public void Play(string audioName)
    {
        AudioClip clip = Resources.Load<AudioClip>(audioName);
        if (clip != null)
        {
            _audioSource.clip = clip;
            _audioSource.Play();
        }
        else
        {
            Debug.LogWarning($"Audio clip '{audioName}' not found.");
        }
    }

    public void Stop()
    {
        _audioSource.Stop();
    }

    public void SetVolume(float volume)
    {
        _audioSource.volume = Mathf.Clamp01(volume);
    }
}