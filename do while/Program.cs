// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



bool nomeCerto = false;

while(nomeCerto == false){
Console.WriteLine($"Nome do Usuario:");
string nome = Console.ReadLine();

if (nome != string.Empty)
{
    
    nomeCerto = true;
}
else
{
   nomeCerto=false;
    
}
};

bool idadeCerto = false;
while(idadeCerto==false){
    Console.WriteLine($"Idade do Usuario:");
    int idade = int.Parse(Console.ReadLine());

    if(idade>0&&idade<100)
    {
        
        idadeCerto=true;
        
    }
    else{
        
        idadeCerto=false;
    }
    
};

bool salary= false;
while(salary==false)
{
    Console.WriteLine($"Informe o salario do Usuario");
    float money = float.Parse(Console.ReadLine());

    if(money>0)
    {
        salary=true;
    }    
    else{
        salary=false;
    }
}

bool civil=false;

while(civil==false)
{
    Console.WriteLine($"Informe o Estado civil do Usuario");
    char relacao = char.Parse(Console.ReadLine());

    if(relacao=='s')
    {
        civil=true;
        Console.WriteLine($"solteiro");
        
    }
    else if(relacao=='c')
    {
        civil=true;
        Console.WriteLine($"Casado");
        
    }
    else if(relacao=='v')
    {
        civil=true;
        Console.WriteLine($"viuvo");
        
    }
    else if(
        relacao=='d'
    )
    {
        civil=true;
        Console.WriteLine($"Divorciado");
        
    }
    else
    {
        civil=false;
    }
    
}