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
int num =inputNumber();
int res =0;
while (num >0)
{
    res = res + num % 10;
    num = num / 10;

}
System.Console.WriteLine(res);