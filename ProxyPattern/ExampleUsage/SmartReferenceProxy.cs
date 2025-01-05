using System;

namespace DesignPattern.Structural.ProxyPattern.ExampleUsage;

public class SmartReferenceProxy : IRenderObject
{
    private RealRenderObject _realRenderObject;
    private string _modelName;
    private int _referenceCount = 0;

    public SmartReferenceProxy(string modelName)
    {
        _modelName = modelName;
    }

    public void AddReference()
    {
        _referenceCount++;
        Console.WriteLine($"Reference added. Current reference count: {_referenceCount}");

        if (_realRenderObject == null)
        {
            _realRenderObject = new RealRenderObject(_modelName);
        }
    }

    public void RemoveReference()
    {
        if (_referenceCount > 0)
        {
            _referenceCount--;
            Console.WriteLine($"Reference removed. Current reference count: {_referenceCount}");

            if (_referenceCount == 0)
            {
                Console.WriteLine($"No references left. Unloading 3D model {_modelName}...");
                _realRenderObject = null;
            }
        }
    }

    public void Display()
    {
        if (_realRenderObject != null)
        {
            _realRenderObject.Display();
        }
        else
        {
            Console.WriteLine($"3D model {_modelName} is not loaded.");
        }
    }
}