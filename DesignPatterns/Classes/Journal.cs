using System;
using System.Collections.Generic;

namespace DesignPatterns.Classes
{
    public class Journal
    {
        private static int _count;

        // Properties
        private readonly List<string> _entries = new List<string>();

        // Methods
        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; // memento 
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }
    }
}