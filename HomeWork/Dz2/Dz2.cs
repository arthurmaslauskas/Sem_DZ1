// * *Задание 2:**Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите Число A:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Число B:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Число C:");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine("1)Число A Больше Чем B");
}
else
{
    Console.WriteLine("1)Число B Больше Чем A");
}
if (numberB > numberC)
{
    Console.WriteLine("2)Число B Больше Чем С");
}
else
{
    Console.WriteLine("2)Число C Больше Чем В");
}
if (numberC > numberA)
{
    Console.WriteLine("3)Число C Больше Чем A");
}
else
{
    Console.WriteLine("Число A Больше С");
}
Console.ReadKey();
