using System;
using TimeKeeper.ConsoleWriting;
namespace TimeKeeper.DateWriting
{
    public class TodayWriter : IDateWriter
    {
        private IOutput output;

        public TodayWriter(IOutput a_output)
        {
            this.output = a_output;
        }

        public void WriteDate() {
            this.output.Write(DateTime.Today.ToShortTimeString());
        }
    }
}
