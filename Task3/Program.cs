// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7, которые обозначают дни недели: ");
int dayNumbers = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumbers){
if (dayNumbers == 7 | dayNumbers == 6)
    {
        Console.WriteLine("это-выходной день ");
    }
    else if (dayNumbers < 1 | dayNumbers > 7 )
    {
        Console.WriteLine("это вообще не день недели ");
    }
    else
    Console.WriteLine("этот день не выходной ");
}
CheckingTheDayOfTheWeek(dayNumbers);

