using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle
{
    public class Bad_Way_Todo
    {

        #region [ collection & Methods]
        List<string> entries = new List<string>();
        public int AddEntry(string item)
        {
            entries.Add(item);
            return entries.Count;
        }
        public int RemoveEntry(int index)
        {
            entries.RemoveAt(index);
            return entries.Count;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        #endregion

        #region [ Persistence ]
        public void SaveToFile(Todo todo, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, todo.ToString());
            }
        }

        #endregion
    }
}