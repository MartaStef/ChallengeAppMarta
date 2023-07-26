using ChallengeAppMarta;

var employee = new Employee("Marta", "Stefanska", 53);
employee.AddGrade(800);
employee.AddGrade("Marta");
employee.AddGrade(10);
employee.AddGrade(3.345567);

var statistics1 = employee.GetStatisticsWithForeach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("   1 With Foreach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: { statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("   2 With For");
Console.WriteLine($"Average: { statistics2.Average:N2}");
Console.WriteLine($"Min: { statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("   3 With dowhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine("   4 With while");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");