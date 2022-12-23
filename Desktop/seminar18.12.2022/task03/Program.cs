// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



Console.WriteLine("Понедельник = 1");
Console.WriteLine("Вторник = 2");
Console.WriteLine("Среда = 3");
Console.WriteLine("Четверг = 4");
Console.WriteLine("Пятница = 5");
Console.WriteLine("Суббота = 6");
Console.WriteLine("Воскресенье = 7");

Console.WriteLine("Введите цифру от 1 до 7");
int num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 >= 1) && (num1 <= 5))
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной день");
}




