// **Задание 1:**Напишите программу,
//  которая на вход принимает два числа и выдаёт,
//   какое число большее,.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3
Console.Clear();
Console.WriteLine("Введите Число A:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Число B:");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("Число A Больше");
}
else if(numberA < numberB)
{
    Console.WriteLine("Число A Меньше");
}
else
{
    Console.WriteLine("Число A и В равны");
}
Console.ReadKey();
