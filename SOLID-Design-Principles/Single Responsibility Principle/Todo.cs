using System;
using System.Collections.Generic;

namespace Single_Responsibility_Principle
{
  public  class Todo
    {
         List<string> entries = new List<string>();
         public int AddEntry(string item)
         {
             entries.Add(item);
             return entries.Count;
         }
         public int RemoveEntry(int index )
         {
             entries.RemoveAt(index);
             return entries.Count;
         }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}