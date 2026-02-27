using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    internal class Journal
    {
        private readonly List<string> entries = new List<string>();

        public static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento pattern
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
            count--;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        #region Breaks Single Responsibility Principle
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllLines(filename, entries);
        }

        public void Load(string filename)
        {
            throw new NotImplementedException();
        }

        public void Load(Uri uri)
        {
            throw new NotImplementedException();
        }
        #endregion Breaks Single Responsibility Principle
    }
}
