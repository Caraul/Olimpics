using System;

namespace Olimp2
{
    public class Program2
    {
        static public int DayOfWeek, month, DayOfMonth, weekday, weekend;
        static void Main(string[] args)
        {
            prog(2018, 3);
        }
        static public void prog(int nyear, int nweekend)
        {
            month = 1;
            DayOfMonth = 1;
            DayOfWeek = Day(nyear);
            NumOfBonusWeekend(nweekend, nyear);
            Console.WriteLine(DayOfMonth + " " + month);
        }

        static public (int, int) NumOfBonusWeekend(int nweekend, int nyear)
        {
            DayOfMonth = 0;
            while (weekend != nweekend)
            {

                if (weekday != 3 && DayOfWeek != 6 && DayOfWeek != 7)
                {
                    weekday += 1;
                    DayOfMonth += 1;
                    DayOfWeek = Day(nyear);
                }
                else if (DayOfWeek == 6 || DayOfWeek == 7)
                {
                    DayOfMonth += 1;
                    DayOfWeek = Day(nyear);
                }
                else
                {
                    weekend += 1;
                    DayOfMonth += 1;
                    weekday = 0;
                    DayOfWeek = Day(nyear);
                }
                if(month == 0)
                {
                    break;
                }
            }
            return (DayOfMonth, month);
        }
        static public int Day(int nyear)
        {
            if (DayOfMonth > System.DateTime.DaysInMonth(nyear, month))
            {
                DayOfMonth = 1;
                month += 1;
            }
            if (month > 12)
            {
                DayOfMonth = 0;
                month = 0;
                return 0;
            }
            DateTimeOffset day = new DateTimeOffset(nyear, month, DayOfMonth, 0, 0, 0, DateTimeOffset.Now.Offset);
            switch (Convert.ToString(day.DayOfWeek))
            {
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
            }
            throw new Exception("something go wrong");
        }
    }
}