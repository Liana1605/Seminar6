﻿// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

int a = 2;
int b = 5;
int c = 4;

if ((a < b + c) && (b < a + c) && (c < a + b))
{
    Console.WriteLine("Получается треугольник");
}
else
{
   Console.WriteLine("Не получился треугольник");
}