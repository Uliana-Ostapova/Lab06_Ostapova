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
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     bool flag = false;
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
// int n = 0;
// for (int i = 1; i <= 5; i++) {
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number > 42) {
//         Console.WriteLine("Меньше");
//         n++;
//     } else {
//         Console.WriteLine("Больше");
//         n++;
//     }
// }
// if (number == secret) {
//         Console.WriteLine($"Победа! Попыток: {n}");
//     } else {
//         Console.WriteLine("Вы проиграли, число было 42");
//     }