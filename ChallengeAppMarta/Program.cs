using ChallengeAppMarta;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine("Należy podać kolejno oceny pracownika od 0 do 100");
Console.WriteLine("lub litery od a do e");
Console.WriteLine("Aby wyświetlić statystyki należy wpisać literę q");
Console.WriteLine();

var employee = new Employee("Marta", "Stefanska", 53);

while (true) 
{ 
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    { 
        break; 
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
