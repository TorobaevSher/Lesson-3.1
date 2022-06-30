// Напишите программу, которая на входе принимает
// два числа и проверяет, является ли первое 
//  число квадратом второго.
// а=25, б=5->да
// а=2, б=10->нет
// а=9, б=-3->даclear
// а=-3, б=0->нет.

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if (second * second == first)
{
    Console.WriteLine("Да");    
}
else
{
    Console.WriteLine($"Нет");
}