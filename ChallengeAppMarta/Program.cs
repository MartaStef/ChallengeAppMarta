using ChallengeAppMarta;

Employee employee1 = new Employee ("Gosia","Pocahontas", 45);
Employee employee2 = new Employee ("Iwona", "Kopciuszek", 60);
Employee employee3 = new Employee ("Magda", "Spiaca", 24);
Employee employee4 = new Employee ("Wicky", "Sniezka", 23);

employee1.AddScore(8);
employee1.AddScore(-2);
employee1.AddScore(9);
employee1.AddScore(-1);

employee2.AddScore(8);
employee2.AddScore(0);
employee2.AddScore(10);
employee2.AddScore(-1);

employee3.AddScore(6);
employee3.AddScore(-1);
employee3.AddScore(7);
employee3.AddScore(0);

employee4.AddScore(7);
employee4.AddScore(-1);
employee4.AddScore(8);
employee4.AddScore(-1);

List<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,employee4
};

int maxResult = 0;
Employee bestEmployee = null;

foreach (var employee in employees) 
{
    if (employee.Result> maxResult)
    { 
        maxResult= employee.Result;
        bestEmployee = employee; 
    }
}

Console.WriteLine(
"Najlepszy pracownik: " + bestEmployee.Name +" "+ bestEmployee.Surname+", lat "+
bestEmployee.Age+", uzyskala wynik "+bestEmployee.Result + " punktow");
 