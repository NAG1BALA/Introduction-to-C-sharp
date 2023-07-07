﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int numberM = 4;
int numberN = 8;

void Perechislenie(int LastNumber)
{
    if(LastNumber < numberM) return;
    Perechislenie(LastNumber - 1);
    Console.Write(LastNumber + "  ");
}
Perechislenie(numberN);