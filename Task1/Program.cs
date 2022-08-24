// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

static void PrintNumbers ()
{

Console.WriteLine("Введите целое трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

    if((numbers >= 100 && numbers < 1000))
    {
        Console.WriteLine(numbers + " трехзначное число");
        int resalt = (numbers / 10) % 10;
        Console.WriteLine(resalt + " вторая цифра введенного числа");
    }
     else
    {
        Console.WriteLine("Вы ввели не трехзначное число ");
    }
}
PrintNumbers ();

