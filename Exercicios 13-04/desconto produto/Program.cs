// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira um produto que voce queira:");
string produto = Console.ReadLine();

Console.WriteLine($"Insira a quantidade que voce deseja:");
int quantidade= int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o preco unitario do produto que deseja?:");
float uni = float.Parse(Console.ReadLine());

double rir = 2/100;
double rar = 3/100;
double ror = 5/100;

float total= quantidade*uni;

if(quantidade<=5){
   double totall= total-(0.02*total);
   Console.WriteLine($"O total a se pagar e R${totall} reais");
   
}
else if(quantidade>5 && quantidade<=10)
{
    double totil=total-(0.03*total);
    Console.WriteLine($"O total a se pagar e R${totil} reais");
    
}
else if(quantidade>10 )
{
    double totau=total-(0.05*total);
    Console.WriteLine($"O total a se pagar e R${totau} reais");
    
}


