int number = 45661133;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char digit in letters)
    {
        if (int.Parse(digit.ToString()) == i)
        { counter++; }
    }
    Console.WriteLine(i + "=>" + counter);
}