// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите поряддковый номер дня недели: ");
string? numberDay = Console.ReadLine();

switch (numberDay)
{
    case "1":
        Console.WriteLine("понедельник");
        break;
    case "2":
        Console.WriteLine("вторник");
        break;
    case "3":
        Console.WriteLine("среда");
        break;
    case "4":
        Console.WriteLine("четверг");
        break;
    case "5":
        Console.WriteLine("пятница");
        break;
    case "6":
        Console.WriteLine("суббота");
        break;
    case "7":
        Console.WriteLine("воскресенье");
        break;
    default:
        Console.WriteLine("Вы ввели неправильный порядковый номер! Такого дня не существует!");
        break;
}

