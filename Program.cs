/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите день недели...");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7) 
Console.WriteLine("Ответ: Выходной день.");
else if (num <= 5) 
Console.WriteLine("Ответ: Будний день.");
else if (num > 7) 
Console.WriteLine("Ошибка: В неделе всего 7 дней!");
