using UnityEngine;

namespace DesignPattern.Structural.AdapterPattern.ExampleUsage;

//CLIENT
public class GameAudioManager : MonoBehaviour
{
    private IAudioPlayer _audioPlayer;

    private void Start()
    {
        FMODAudioSystem fmodAudioSystem = new FMODAudioSystem();

        _audioPlayer = new FMODAudioAdapter(fmodAudioSystem);
        
        _audioPlayer.Play("BackgroundMusic");
        _audioPlayer.SetVolume(0.8f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _audioPlayer.Stop();
        }
    }
}