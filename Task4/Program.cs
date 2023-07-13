int a;
int b;
int c;

int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
int.TryParse(Console.ReadLine(), out c);

Console.WriteLine("max " + (a > b ? (a > c ? a : c) : (b > c ? b : c)));