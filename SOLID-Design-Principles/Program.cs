using System;
using Single_Responsibility_Principle;

namespace SOLID_Design_Principles
{

    class Program
    {


        static void Single_Responsibility_Principle_Client()
        {
            try
            {
                Todo todo = new Todo();

                #region [ Add todo ]
                todo.AddEntry("Complete Solid Principle");
                todo.AddEntry("Complete Builder patterns");
                todo.AddEntry("Complete Behavioral pattern");
                #endregion

                Persistence p = new Persistence();
                #region [ Persistence ]

                p.SaveToFile(todo, "/tasklist.txt");

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Single_Responsibility_Principle_Client();
        }
    }
}
