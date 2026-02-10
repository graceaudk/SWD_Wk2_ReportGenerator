namespace ReportGenerator
{
    internal class ReportGeneratorFormat
    {
       // private ReportOutputFormatType _currentOutputFormat;

    
    public void Format(ReportOutputFormatType _currentOutputFormat)
        {
            switch (_currentOutputFormat)
            {
                case ReportOutputFormatType.NameFirst:
                    Console.WriteLine("Name-first report");
                    foreach (var e in employees)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Name: {0}", e.Name);
                        Console.WriteLine("Salary: {0}", e.Salary);
                        Console.WriteLine("------------------");
                    }
                    break;

                case ReportOutputFormatType.SalaryFirst:
                    Console.WriteLine("Salary-first report");
                    foreach (var e in employees)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Salary: {0}", e.Salary);
                        Console.WriteLine("Name: {0}", e.Name);
                        Console.WriteLine("------------------");
                    }
                    break;
            }
        }
        }
    }
