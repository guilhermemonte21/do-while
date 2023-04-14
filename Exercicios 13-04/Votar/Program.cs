// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Qual o ano do seu nascimento?:");
int niver = int.Parse(Console.ReadLine());

if(niver<=2007 && niver>=2005)
{
    Console.WriteLine($"Voce podera votar, porem não sera obrigatorio");
    
}
else if(niver<=2005)
{
    Console.WriteLine($"Voce é obrigado a votar palhaço");
    
}
else if (niver>2023)
{
    Console.WriteLine($"Bota a data direito ai mano");
    
}
else
{
    Console.WriteLine($"Voce não pode votar");
    
}
