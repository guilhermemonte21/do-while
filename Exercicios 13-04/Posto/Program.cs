// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine($"Bem vindo ao Posto do Gui!!!");


Console.WriteLine($"Vai querer A-(alcool) ou G-(gasolina)?");
Char tipo =char.Parse (Console.ReadLine());

Console.WriteLine($"Quantos litros vai querer?");
float litros = float.Parse(Console.ReadLine());

double rum = (litros*0.97)*4.90;
double rar = (litros*0.95)*4.90;
double ril = (litros*0.96)*5.30;
double rop = (litros*0.94)*5.30;

if(tipo=='A' && litros<=20)
{
    Console.WriteLine($"Voce tera que pagar {rum} reais");
    
}
else if(tipo=='A'&& litros>20){
    Console.WriteLine($"Voce vai pagar {rar} reais");
    
}

else if ( tipo =='G'&& litros <= 20)
{
    Console.WriteLine($"Voce vai pagar {ril} reais");
    
}
else if( tipo == 'G'&& litros > 20 )
{
    Console.WriteLine($"Voce vai pagar {rop} reais");
    
}
   






