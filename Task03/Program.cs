// Программа, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

// ДВА СПОСОБА РЕШЕНИЯ. 

Console.Write("Введите номер дня недели: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1) Console.Write("Понедельник");
// else if (number == 2) Console.WriteLine("Вторник");
// else if (number == 3) Console.WriteLine("Среда");
// else if (number == 4) Console.WriteLine("Четверг");
// else if (number == 5) Console.WriteLine("Пятница");
// else if (number == 6) Console.WriteLine("Суббота");
// else if (number == 7) Console.WriteLine("Воскресенье");
// else
// {
//     Console.WriteLine("Такого дня недели не существует. ");
// }

string day = Console.ReadLine();

switch (day)                        // метод switch, сравнение строки
{
    case "1":                       // условие 
        Console.WriteLine("Понедельник.");
        break;                      // если условее совпадает, проверка останавливается 
    case "2":
        Console.WriteLine("Вторник.");
        break;
    case "3":
        Console.WriteLine("Среда.");
        break;
    case "4":
        Console.WriteLine("Четверг.");
        break;
    case "5":
        Console.WriteLine("Пятница.");
        break;
    case "6":
        Console.WriteLine("Суббота.");
        break;
    case "7":
        Console.WriteLine("Воскресенье.");
        break;
    default:
        Console.WriteLine("Вы ввели некорректные данные.");
        break;
}
