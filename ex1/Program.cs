// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
int c = 1;

for (int i = 1; i <= numberB; i= i+1);

{
  c = c * numberA * numberA;
}
Console.WriteLine ( c );