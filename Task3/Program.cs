﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот
// день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введи число дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x < 6)
{
    System.Console.WriteLine("Нет, это не выходной день");
}
else
{
    System.Console.WriteLine("Ура, это выходной день");
}