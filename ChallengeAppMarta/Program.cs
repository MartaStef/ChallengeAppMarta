using ChallengeAppMarta;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine("Należy podać kolejno oceny pracownika: 0-100 lub litery a-e");
Console.WriteLine("dla kierownika można dodatkowo w skali: 1-6 (z '+' i '-')");
Console.WriteLine("Aby wyświetlić statystyki należy wpisać literę q");
Console.WriteLine();

var employee = new Employee("Marta", "Stefanska", 53);
var supervisor = new Supervisor("Marta","Stefanska",'K', 53);

bool exit = true;

while (exit)
{
    Console.WriteLine("Wybierz pracownika: p lub kierownika: k");
    var option = Console.ReadLine();
    if (option == "p")
    {
        while (true)
        {
            Console.WriteLine("Podaj ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q" || input == "Q")
            {
                exit = false;
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
        var statistics1 = employee.GetStatistics();
        Console.WriteLine($"Average: {statistics1.Average}");
        Console.WriteLine($"Max: {statistics1.Max}");
        Console.WriteLine($"Min: {statistics1.Min}");
    }

    if (option == "k")
    {
        while (true)
        {
            Console.WriteLine("Podaj ocenę kierownika: ");
            var input = Console.ReadLine();
            if (input == "q" || input == "Q")
            {
                exit = false;
                break;
            }

            try
            {
                supervisor.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        var statistics2 = supervisor.GetStatistics();
        Console.WriteLine($"Average: {statistics2.Average}");
        Console.WriteLine($"Max: {statistics2.Max}");
        Console.WriteLine($"Min: {statistics2.Min}");
    }
}


