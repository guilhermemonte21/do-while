// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira um numero");
int number = int.Parse(Console.ReadLine());

for(int multiplicador=1;multiplicador<=10 ;multiplicador++)
{
    Console.WriteLine($"{number} x {multiplicador} = {number*multiplicador}");
    
    
}