using System;

namespace DesignPattern.Structural.AdapterPattern.ExampleUsage;

//ADAPTEE
public class FMODAudioSystem
{
    public void PlaySound(string soundEvent)
    {
        Console.WriteLine($"FMOD: Playing sound '{soundEvent}'.");
    }

    public void StopSound()
    {
        Console.WriteLine("FMOD: Stopping sound.");
    }

    public void SetMasterVolume(float volume)
    {
        Console.WriteLine($"FMOD: Setting volume to {volume * 100}%.");
    }
}