// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine($@"Ola, vamos calcular seu imposto de renda
regras de negocio:
até $1500 - isento
de $1501 até $3500 - 20% de imposto
de $3501 até $6000 - 25% de imposto
acima de $6000 - 35% de imposto");

Console.WriteLine($"Insira sua renda:");
float renda = float.Parse(Console.ReadLine());

 float vinte = renda / 5;
double vintecinco = renda / 4;
double trintacinco = renda * (35/100);

    if(renda<=1500)
    {
        Console.WriteLine($"Voce esta isento do pagamento");
        
    }
    else if(renda>=1501 && renda<=3500)
    {
        Console.WriteLine($"Voce tera que pagar {vinte} reais");
        
        
    }
    else if(renda>=3501 && renda<=6000)
    {
        Console.WriteLine($"Voce tera que pagar {vintecinco} reais");
        
    }
    else if (renda>=6001){
        Console.WriteLine($"Voce tera de pagar {trintacinco } reais");
        
    }




