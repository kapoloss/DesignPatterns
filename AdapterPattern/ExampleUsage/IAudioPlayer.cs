namespace DesignPattern.Structural.AdapterPattern.ExampleUsage;

//TARGET INTERFACE
public interface IAudioPlayer
{
    void Play(string audioName);
    void Stop();
    void SetVolume(float volume);
}