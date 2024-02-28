// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter strings separated by commas:");
        string input = Console.ReadLine()!;
        string[] arr = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        string[] newArr = GetShortStrings(arr);

        Console.WriteLine("New array of strings:");
        foreach (var item in newArr)
        {
            Console.WriteLine(item);
        }
    }

    static string[] GetShortStrings(string[] arr)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] newArr = new string[count];
        int index = 0;
        foreach (var item in arr)
        {
            if (item.Length <= 3)
            {
                newArr[index++] = item;
            }
        }

        return newArr;
    }
}