// Программа, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

//  а = 25, b = 5 -> да
//  а = 2, b = 10 -> нет
//  а = 9, b = -3 -> да
//  а = -3 b = 9 -> нет

Console.Write("Введите первое число: ");

//Convert.ToInt32(Console.ReadLine()); - преобразование строки в число

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA / numberB == numberB)
{
    Console.WriteLine($"Число {numberA}, является квадратом числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA}, не является квадратом числа {numberB}");
}
