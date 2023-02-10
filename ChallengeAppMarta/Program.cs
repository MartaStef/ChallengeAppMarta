var name = "Marta";
bool women = true;
int age = 50;
if (name == "Ewa" && age < 50)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!women && age != 50)
{
    Console.WriteLine("Mezczyzna Twojego Zycia");
}
else if (women == true && age < 50)
{
    Console.WriteLine("Kobieta ponizej 50 lat");
}
else
{
    Console.WriteLine("Marta, lat 52 poczatkujacy programista C#");
}

