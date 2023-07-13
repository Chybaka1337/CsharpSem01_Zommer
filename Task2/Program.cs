int a;
int b;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("max " + (a > b ? a : b));