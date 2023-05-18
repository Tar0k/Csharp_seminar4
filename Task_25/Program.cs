// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

var A = GetValueFromUser("A");
if (A == null) Environment.Exit(0);

var B = GetValueFromUser("B");
if (B == null) Environment.Exit(0);

var result = double.Pow(A.Value, B.Value);
Console.WriteLine($"Результат: {result}");

double? GetValueFromUser(string definition)
{
    Console.Write($"Введите число {definition}: ");
    var text = Console.ReadLine();
    if (int.TryParse(text, out var value)) return (double)value;
    
    Console.WriteLine($"Не корректный ввод числа {definition}");
    return null;
}