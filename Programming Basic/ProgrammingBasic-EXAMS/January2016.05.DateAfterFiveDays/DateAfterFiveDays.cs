using System;

class DateAfterFiveDays
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int daysInMonth = 0;
        int nextDay = 0;
        int nextMonth = 0;

        if (month == 01) daysInMonth = 31;
        if (month == 02) daysInMonth = 28;
        if (month == 03) daysInMonth = 31;
        if (month == 04) daysInMonth = 30;
        if (month == 05) daysInMonth = 31;
        if (month == 06) daysInMonth = 30;
        if (month == 07) daysInMonth = 31;
        if (month == 08) daysInMonth = 31;
        if (month == 09) daysInMonth = 30;
        if (month == 10) daysInMonth = 31;
        if (month == 11) daysInMonth = 30;
        if (month == 12) daysInMonth = 31;

        if ((day + 5) > daysInMonth)
        {
            nextDay = (day + 5) - daysInMonth;
            month++;
            if (month < 10)
            {
                Console.WriteLine("{0}.0{1}", nextDay, month);
            }
            else
            {
                if (month > 12)
                {
                    month = 1;
                    Console.WriteLine("{0}.0{1}", nextDay, month);
                    return;
                }
                Console.WriteLine("{0}.{1}", nextDay, month);
            }
        }
        else
        {
            nextDay = day + 5;
            if (month < 10)
            {
                Console.WriteLine("{0}.0{1}", nextDay, month);
            }
            else
            {
                if (month > 12)
                {
                    month = 1;
                    Console.WriteLine("{0}.0{1}", nextDay, month);
                    return;
                }
                Console.WriteLine("{0}.{1}", nextDay, month);
            }
        }

    }
}

