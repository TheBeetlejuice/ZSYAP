// Программа, которая на вход принимает число и выводит его квадрат
// (число умноженное на само себя)

// Например: 
//  4 -> 16
//  -3 -> 9
//  -7 -> 49

Console.Write("Введите число, квадрат которого нужно найти: ");

int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.WriteLine($"Квадрат числа {number} = {square}");
