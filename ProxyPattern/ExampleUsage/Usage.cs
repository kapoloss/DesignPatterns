namespace DesignPattern.Structural.ProxyPattern.ExampleUsage;

class Usage
{
    static void Main(string[] args)
    {
        SmartReferenceProxy renderObjectProxy = new SmartReferenceProxy("Castle");

        renderObjectProxy.AddReference();
        renderObjectProxy.Display();

        renderObjectProxy.AddReference();

        renderObjectProxy.RemoveReference();

    }
}