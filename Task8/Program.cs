var flag = uint.TryParse(Console.ReadLine(), out uint a);
if(!flag)
{
    Console.WriteLine("Некорректный ввод (вводимое число должно принадлежать множеству натуральных чисел)");
    return;
}

for(int i = 2; i <= a; i += 2) 
{
    Console.Write(i + "\t");
}