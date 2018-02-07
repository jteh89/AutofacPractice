using System;
namespace TimeKeeper.ConsoleWriting
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string a_content)
        {
            Console.WriteLine(a_content);
        }
    }
}
