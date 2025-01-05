using UnityEngine;

namespace DesignPattern.Structural.AdapterPattern.ExampleUsage;

//ADAPTER
public class FMODAudioAdapter : IAudioPlayer
{
    private FMODAudioSystem _fmodAudioSystem;

    public FMODAudioAdapter(FMODAudioSystem fmodAudioSystem)
    {
        _fmodAudioSystem = fmodAudioSystem;
    }

    public void Play(string audioName)
    {
        _fmodAudioSystem.PlaySound(audioName);
    }

    public void Stop()
    {
        _fmodAudioSystem.StopSound();
    }

    public void SetVolume(float volume)
    {
        _fmodAudioSystem.SetMasterVolume(volume);
    }
}