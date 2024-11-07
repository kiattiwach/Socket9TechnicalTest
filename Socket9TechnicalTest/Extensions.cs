namespace Socket9TechnicalTest;

public class Extensions
{
    private static readonly string[] Weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    private static readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    public static string GetWeekday(int day, int month, int year)
    {
        var totalDays = 0;

        // Add days for each year from 1900 to the year before the input year
        for (var y = 1900; y < year; y++)
        {
            totalDays += IsLeapYear(y) ? 366 : 365;
        }

        // Add days for each month of the input year up to the month before the input month
        for (var m = 1; m < month; m++)
        {
            totalDays += DaysInMonth[m - 1];
            // Adjust for leap year in February
            if (m == 2 && IsLeapYear(year))
            {
                totalDays += 1;
            }
        }

        // Add the days in the input month
        totalDays += day - 1;

        // Calculate the weekday by taking modulo 7
        int weekdayIndex = totalDays % 7;

        // Return the weekday name
        return Weekdays[weekdayIndex];
    }

    private static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}