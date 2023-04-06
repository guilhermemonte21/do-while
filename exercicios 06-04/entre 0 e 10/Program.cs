// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



bool entre = false;

while(entre==false)
{
    Console.WriteLine($"Insira uma nota entre 0 e 10");
int nota = int.Parse(Console.ReadLine());
    if(nota>=0&&nota<=10){
        entre=true;
    }
    else
    {
        entre=false;
    }
}