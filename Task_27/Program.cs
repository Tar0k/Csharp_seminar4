// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
var number = GetValueFromUser();
if (number == null) Environment.Exit(0);

var result = number.Select(char.GetNumericValue).Sum();
Console.WriteLine($"Результат: {result}");


string? GetValueFromUser()
{
    Console.Write($"Введите число: ");
    var text = Console.ReadLine();
    if (int.TryParse(text, out _)) return text;
    
    Console.WriteLine($"Не корректный ввод числа");
    return null;
}