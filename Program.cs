﻿

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
// Console.WriteLine("Введите пятизначное число: ");

// string number = Console.ReadLine();
// int amount = number.Length;

// if (amount > 5)
// {
//     Console.WriteLine($"число: {number} - не является пятизначным");
// }
// else
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"число {number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"число {number} - НЕ палиндром");
//     }
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координаты точки X1:");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y1:");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координаты точки X2:");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координаты точки y2:");
// int y2 = int.Parse(Console.ReadLine());

// double resalt =  Math.Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));

// Console.WriteLine($"рачтоние между точками {Math.Round(resalt,2)}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

// 10 -> 4
// 20 -> 7
// 30 -> 8

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, и вывести на экран те (тот), где чаще всего встречается введённая буква.

// Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"