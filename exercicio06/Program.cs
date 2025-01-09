// Peça um numero inteiro,retorne se é um numero positivo, neutro ou negativo.


// ex:
// -5: negativo
// 34: positivo
// -3: negativo
// 0: neutro


Console.WriteLine("Informe um número");
int numero = Convert.ToInt16(Console.ReadLine());

if(numero < 0)
{
  Console.WriteLine("Número Negativo");
}
else if(numero >= 1)
{
  Console.WriteLine("Número Positivo");
}
else 
{ 
  Console.WriteLine("Número neutro");
}