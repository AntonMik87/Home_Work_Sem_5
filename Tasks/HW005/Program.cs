// https://codeforces.com/contest/546/problem/A
Console.WriteLine("Долларов за первый бана: ");
int k = int.Parse(Console.ReadLine() ?? "0");    //k = 3
Console.WriteLine("Сколько хочет купить бананов: ");
int w = int.Parse(Console.ReadLine() ?? "0");  // w = 4
Console.WriteLine("Введите количество долларов у солдата: ");
int n = int.Parse(Console.ReadLine() ?? "0"); // n = 17
int s = 0;
s = k * (w * (w + 1) / 2);
s = s - n;
Console.Write($"Чтобы купить бананы, солдату не хватает: {s} долларов");