// * *Задание 4:**Напишите программу, 
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5  -> 2, 4
// 8  -> 2, 4, 6, 8
//Console.Clear();
//Console.WriteLine("Число n:");
//if(int.Parse(Console.ReadLine()) % 2 == 0);
//for (int i=0; i<50; i++);
//{
//    Console.WriteLine("Число n:");
//    
//}  
//Console.ReadKey();
Console.Clear();
Console.WriteLine("Число n:");
int num = int.Parse(Console.ReadLine());
int n = 1;
while (n < num)
{
  Console.WriteLine(n+1);
  n+= 2;
 }
 Console.ReadKey();
// Уже не знаю как удалить крайнее число повторения, а точнее его отделить.
// добавил комменатрий