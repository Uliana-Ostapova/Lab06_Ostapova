// задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// задание 1.2
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// задание 2
// int sum3 = 0;
// int count7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 7 == 0)
//     {
//         count7++;
//     }
//     if (i % 3 == 0)
//     {
//         sum3 += i;
//     }
// }
// Console.WriteLine($"Сумма кратных 3: {sum3} | Количество кратных 7: {count7}");

// задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int pol = 0;
// int otr = 0;
// while (number != 0)
// {
//     if (number > 0)
//     {
//         pol++;
//     } else
//     {
//         otr++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {pol} | Отрицательных чисел: {otr}");

// задание 4
// string password;
// bool flag = false;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     for (int i = 1; i < 3; i++)
//     {
//         if (password == "qwerty")
//         {
//             Console.WriteLine("Доступ разрешён");
//             flag = true;
//             break;
//         }
//         Console.Write("Введите пароль: ");
//         password = Console.ReadLine();
//     }
//     if (flag == false)
//     {
//         Console.WriteLine("Доступ заблокирован");
//         break;
//     }
// }
// while (password != "qwerty");

// задание 5
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{number} x {i} = {i * number}");
// }

// задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0) continue;
//     if (i % 10 == 0 & i > 20) break;
//     Console.WriteLine(i);
// }

// задание "угадай число"
// int secret = 42;
// bool flag = false;
// Console.Write("Угадайте число от 1 до 100: ");
// for (int i = 1; i <= 5; i++) {
//     int number = int.Parse(Console.ReadLine());
//     if (number == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         flag = true;
//         break;
//     } else if (number > 42) {
//         Console.WriteLine("Меньше");
//     } else {
//         Console.WriteLine("Больше");
//     }
// }
// if (flag == false)
// {
//     Console.WriteLine("Вы проиграли, число было 42");
// }

// дополнительное задание
Console.Write("Введите целое положительное число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
while (n > 0)
{
    int number = n % 10;
    sum += number;
    count++;
    n /= 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");
Console.WriteLine($"Количество цифр числа: {count}");