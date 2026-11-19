//Шаг 1.
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

//Задание 1.1.
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

//Задание 1.2.
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }

// Шаг 2.
// int sum = 0;
// for (int i = 1; i <= 10; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}");
// int count = 0;
// for (int i = 1; i <= 20; i++)
// {
//     if (i % 5 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");

//Задание 2.
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Сумма чисел, крастных 3: {sum}, Количество чисел, кратных 7: {count}");

// Шаг 3.
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Сумма: {total}");

//Задание 3.
// int number = Convert.ToInt32(Console.ReadLine());
// int positive = 0;
// int negative = 0;
// while (number != 0)
// {
//     if (number > 0)
//     {
//         positive++;
//     }
//     else {
//         negative++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных: {positive}, Отрицательных: {negative}");

// Шаг 4.
// string password;
// do
// {
//     Console.Write($"Введите пароль: ");
//     password = Console.ReadLine();
// }
// while (password != "qwerty");
// Console.WriteLine("Доступ разрешён");

//Задание 4.
// Console.WriteLine("Введите пароль: ");
// string password = Console.ReadLine();
// bool YES_or_NO = false;
// for (int i = 1; i < 3; i++)
// {
//     if (password == "qwerty")
//     {
//         YES_or_NO = true;
//         break;
//     }
//     password = Console.ReadLine();
// }
// if (YES_or_NO)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ заблокирован");
// }

//Задание 5. Таблица умножения.
// Console.WriteLine("Введите число (1-9): ");
// int num = int.Parse(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{num} x {i} = {num * i}");
// }

//Задание 6. Числа без троек.
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

//Итоговая задача. «Угадайчисло»
int secret = 42;
int count =  1;
Console.WriteLine("Введите число: ");
int num = 0;
do
{
    num = int.Parse(Console.ReadLine());
    if (num == secret)
    {
        Console.WriteLine($"Победа! Попыток: {count}");
        break;
    }
    else if (num < secret)
    {
        Console.WriteLine("Больше!");
    }
    else if (num > secret)
    {
        Console.WriteLine("Меньше!");
    }
    count++;
}
while (count <= 5);
if (num != secret)
{
    Console.WriteLine($"Вы проиграли, число было {secret}");
}