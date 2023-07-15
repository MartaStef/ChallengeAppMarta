using ChallengeAppMarta;

var employee = new Employee("Marta", "Stefanska", 53);
employee.AddGrade(800);
employee.AddGrade("Marta");
employee.AddGrade(10);
employee.AddGrade(3.345567);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: { statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");