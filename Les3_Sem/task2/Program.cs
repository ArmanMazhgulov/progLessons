﻿// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные 
// элементы на положительные, а положительные на отрицательные.
// Пример

// [1 -5 6]
// => [-1 5 -6]

int[] arr = new int[10] { 2, 7, 1, -4, 8, -1, 6, 7, 9, -2 };

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
    //    Console.WriteLine(arr[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}