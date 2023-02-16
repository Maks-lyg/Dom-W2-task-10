Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int num = 0;
num = (x / 100) * 100;
num = (x - num) / 10;
Console.WriteLine($"Второе число -> {num}");