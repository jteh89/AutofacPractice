using System;
namespace TimeKeeper.DateRetrieval
{
    public class TodayDateRetriever : IDateRetreiver
    {
        public DateTime RetrieveDate() {
            return DateTime.Now;
        }
    }
}
