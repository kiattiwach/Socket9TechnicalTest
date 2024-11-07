using CommandLine;

namespace Socket9TechnicalTest.Command;

[Verb("getweekdaytoday", HelpText = "Get weekday for the current day")]
public class GetWeekDayTodayCommand: ICommand
{
    public void Execute()
    {
        var currentDay = DateTime.Now;
        Console.WriteLine(Extensions.GetWeekday(currentDay.Day, currentDay.Month, currentDay.Year));
    }
}