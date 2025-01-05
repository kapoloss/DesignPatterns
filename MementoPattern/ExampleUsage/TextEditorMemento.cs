namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public class TextEditorMemento
    {
        public string Content { get; }

        public TextEditorMemento(string content)
        {
            Content = content;
        }
    }
}