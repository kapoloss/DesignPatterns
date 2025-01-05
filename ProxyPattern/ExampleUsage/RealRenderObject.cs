using System;

namespace DesignPattern.Structural.ProxyPattern.ExampleUsage;

public class RealRenderObject : IRenderObject
{
    private string _modelName;

    public RealRenderObject(string modelName)
    {
        _modelName = modelName;
        LoadModel();
    }

    private void LoadModel()
    {
        Console.WriteLine($"Loading 3D model {_modelName}...");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying 3D model {_modelName}");
    }
}