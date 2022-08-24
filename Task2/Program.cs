// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
static void PrintNumbers ()
{

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("третья цифра " + numberText[2]);
}
else
{
    Console.WriteLine(" третьей цифры нет ");
}

}
PrintNumbers ();
