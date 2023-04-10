// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Ola, como vai seu dia");
string saudacoes = Console.ReadLine();

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    for( int multiplicado = 1; multiplicado <= 10;multiplicado++){
        Console.WriteLine($"{multiplicado} x {multiplicador} = {multiplicado*multiplicador}");
        
    }
    
}

