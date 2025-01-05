using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public class Caretaker
    {
        private readonly Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

        public void Save(TextEditor editor)
        {
            Console.WriteLine("Saving state...");
            _history.Push(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
            {
                Console.WriteLine("Restoring state...");
                editor.Restore(_history.Pop());
            }
            else
            {
                Console.WriteLine("No states to restore.");
            }
        }
    }
}