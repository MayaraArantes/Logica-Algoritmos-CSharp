// Peça duas notas, em seguida a média e retorne a situação.


// 7 - 10: Aprovado(a)
// 5 - 6.9: Recuperação
// 0 - 4.9: Reprovado(a)


//Obter a 1 nota
Console.WriteLine("Digite a primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());

//Obter a 2 nota
Console.WriteLine("Digite a segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1+nota2)/2;

if(media >= 7)
{
  Console.WriteLine($"Aprovado(a) com média: {media}");
}
else if(media >= 5)
{
  Console.WriteLine($"Recuperação com média: {media}");
}
else 
{
  Console.WriteLine($"Reprovado(a) com média:  {media}");
}
