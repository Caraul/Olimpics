using System;

namespace Olimp2
{
    public class Program
    {
        static public int dw, month, dm, wkday, wkend; // DayOfWeek, DayOfMonth, weekday, weekend
        static void Main(string[] args)
        {
            prog(2018, 1);
        }
        static public void prog(int year, int NumberOfBonusWeekend)
        {
            FirstDayOfYear(year);
            NumOfBonusWeekend(NumberOfBonusWeekend, year);
            if (month > 12)
            {
                Console.WriteLine("0 0");
            }
            else
            {
                Console.WriteLine(dm + " " + month);
            }
        }
        static public void NumOfBonusWeekend(int nwkend, int nyear)
        {
            dm = 0;
            month = 1;
            while (wkend != nwkend)
            {
                if (dw > 7)
                {
                    dw = 1;
                }
                else if (dm > DayInMonth(nyear))
                {
                    dm = 1;
                    month += 1;
                }
                else if (wkday != 3 && dw != 6 && dw != 7)
                {
                    wkday += 1;
                    dw += 1;
                    dm += 1;
                }
                else if (dw == 6 || dw == 7)
                {
                    dm += 1;
                    dw += 1;
                }
                else
                {
                    wkend += 1;
                    dm += 1;
                    dw += 1;
                    wkday = 0;
                }
                if (month > 12)
                {
                    break;
                }
            }
        }
        static public int DayInMonth(int nyear)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if (nyear % 4 == 0)
            {
                return 29;
            }
            else
            {
                return 28;
            }
        }
        static public void FirstDayOfYear(int nyear)
        {
            if (nyear > 2037 || nyear < 1902)
            {
                throw new Exception("year");
            }
            nyear -= 1901;
            while (nyear > 28)
            {
                nyear -= 28;
            }
            if (nyear == 1 || nyear == 7 || nyear == 12 || nyear == 18)
            {
                dw = 3;
            }
            else if (nyear == 2 || nyear == 13 || nyear == 19 || nyear == 24)
            {
                dw = 4;
            }
            else if (nyear == 3 || nyear == 8 || nyear == 14 || nyear == 25)
            {
                dw = 5;
            }
            else if (nyear == 4 || nyear == 10 || nyear == 21 || nyear == 27)
            {
                dw = 7;
            }
            else if (nyear == 5 || nyear == 11 || nyear == 16 || nyear == 22)
            {
                dw = 1;
            }
            else if (nyear == 6 || nyear == 17 || nyear == 23 || nyear == 28)
            {
                dw = 2;
            }
            else if (nyear == 9 || nyear == 15 || nyear == 20 || nyear == 26)
            {
                dw = 6;
            }
        }
    }
}
