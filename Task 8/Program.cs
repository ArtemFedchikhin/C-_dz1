// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
        int res = 2;
       
        while(res<=n)
        {
            Console.Write($" {res}");
            res = res+2;
        }
