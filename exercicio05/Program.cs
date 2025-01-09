// Peça um ano e retorne se é bissexto ou não

// Dica: um ano bissexto ocorre a cada 4 anos.



Console.WriteLine("Informe um ano");
int ano = Convert.ToInt16(Console.ReadLine());

if(ano % 4 == 0)
{
  Console.WriteLine("Ano bissexto");
}
else
{
   Console.WriteLine("Não é ano bissexto");
}