﻿Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2!=1)
    Console.WriteLine($"Число {n} является четным");
else 
    Console.WriteLine($"Число {n} не является четным");