using System;

namespace DateModifier
{
    public class DateModifier
    {
        public static int DateDifference(string startDateAsString, string endDateAsString)
        { 
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            TimeSpan difference = endDate - startDate;

            return Math.Abs(difference.Days);
        }
    }
}
