// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.
// M = 1; N = 5 -> "5, 4, 3, 2, 1"
// M = 4; N = 8 -> "8, 7, 6, 5, 4"

using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int m = int.Parse(ReadLine());

Write("Введите число N: ");
int n = int.Parse(ReadLine());

void PrintNumbersA(int m, int n) {
    if (m <= n) {
        Write($"{n}, ");
        n--;
        PrintNumbersA(m, n);
    }
}

void PrintNumbersB(int m, int n) {
    if (m >= n) {
        Write($"{n}, ");
        n++;
        PrintNumbersB(m, n);
    }
} 

void Start(int m, int n) {
    if (m < n){
        PrintNumbersA(m, n);
    }
    else PrintNumbersB(m, n);
}

Start(m, n);