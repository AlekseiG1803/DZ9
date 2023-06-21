// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int m = int.Parse(ReadLine());

Write("Введите число N: ");
int n = int.Parse(ReadLine());

int Start(int m, int n) {

    int sum = 0;

    if(m < n) {
        for (int i = m; i <= n; i++) {
            sum += + i;
        }
    }
    else {
        for (int i = n; i <= m; i++) {
            sum += + i;
            }
    
    }

    return sum;
}

Write(Start(m, n));