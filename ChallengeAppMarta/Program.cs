using ChallengeAppMarta;

var employee = new Employee("Marta", "Stefanska", 53);
employee.AddGrade(8);
employee.AddGrade(0);
employee.AddGrade(10);
employee.AddGrade(-1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: { statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");