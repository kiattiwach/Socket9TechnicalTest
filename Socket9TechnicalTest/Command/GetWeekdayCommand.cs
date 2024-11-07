using CommandLine;
using System.Globalization;

namespace Socket9TechnicalTest.Command;

[Verb("getweekday", HelpText = "Get weekday")]
public class GetWeekdayCommand: ICommand
{
    [Option('d', "day", Required = true, HelpText = "1 - 31")]
    public int Day { get; set; }

    [Option('m', "month", Required = true, HelpText = "1 - 12")]
    public int Month { get; set; }

    [Option('y', "year", Required = true, HelpText = "from 1900")]
    public int Year { get; set; }

    public void Execute()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        var dateString = $"{Day:00}/{Month:00}/{Year:0000}";
        var dateFormat = "dd/MM/yyyy";

        if (DateTime.TryParseExact(dateString, dateFormat, enUS, DateTimeStyles.None, out var currentDay))
        {
            Console.WriteLine(Extensions.GetWeekday(currentDay.Day, currentDay.Month, currentDay.Year));
        }
        else
        {
            Console.WriteLine($"Day: {Day}, Month: {Month}, Year: {Year} is incorrect date!!!");
        }
    }
}