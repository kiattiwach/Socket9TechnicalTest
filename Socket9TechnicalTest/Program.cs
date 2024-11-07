using CommandLine;
using Socket9TechnicalTest.Command;

namespace Socket9TechnicalTest;

class Program
{
    static void Main(string[] args)
    { 
        Parser.Default.ParseArguments<GetWeekDayTodayCommand, GetWeekdayCommand>(args).WithParsed<ICommand>(command => command.Execute());
    }
}