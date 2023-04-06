// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira o nome de usuario:");
string name = Console.ReadLine();
Console.WriteLine($"Insira a senha:");
string senha = Console.ReadLine();

while(name == senha)
{
    Console.WriteLine($"Senha não pode ser igual ao nome");
    senha = Console.ReadLine()!;
};


