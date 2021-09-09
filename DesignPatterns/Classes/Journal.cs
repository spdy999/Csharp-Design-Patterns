using System;
using System.Collections.Generic;
using System.IO;

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

        // These methods are out of scope of Journal class should do
        // We should move it outside to not compromise "Single Responsibility Principle"
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public static Journal Load(string filename)
        {
            return new Journal();
        }

        public void Load(Uri uri)
        {
        }
    }
}