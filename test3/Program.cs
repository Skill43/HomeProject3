int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
int inputNumber1()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите степень: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
int num = inputNumber();
int n = inputNumber1();
int res = 1;
for(int i= 0; i<n; i++)
{
    res*= num;
}
System.Console.WriteLine("{0} ^ {1} = {2}", num, n, res);