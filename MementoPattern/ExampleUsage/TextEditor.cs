using System;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    // Originator 
    public class TextEditor
    {
        private string _content;

        public void SetContent(string content)
        {
            _content = content;
            Console.WriteLine($"Content set to: {_content}");
        }

        public string GetContent()
        {
            return _content;
        }

        // Durumu kaydet
        public TextEditorMemento Save()
        {
            return new TextEditorMemento(_content);
        }

        // Durumu geri yükle
        public void Restore(TextEditorMemento memento)
        {
            _content = memento.Content;
            Console.WriteLine($"Content restored to: {_content}");
        }
    }
}