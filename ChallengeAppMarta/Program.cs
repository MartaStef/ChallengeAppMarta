using ChallengeAppMarta;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine("Należy podać kolejno oceny pracownika: 0-100 lub litery a-e");
Console.WriteLine("Aby wyświetlić statystyki należy wpisać literę q");
Console.WriteLine();

var employee = new EmployeeInFile("Marta", "Stefanska");





        while (true)
        {
            Console.WriteLine("Podaj ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q" || input == "Q")
            {
                break;
            }

            try
            {
                employee.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Average: {statistics.Average}");
        Console.WriteLine($"Max: {statistics.Max}");
        Console.WriteLine($"Min: {statistics.Min}");
    

   
