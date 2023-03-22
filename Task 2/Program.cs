Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m)
    Console.WriteLine($"max = {n}, min = {m}");
else
    Console.WriteLine($"Большее число {m}, меньшее число {n}");