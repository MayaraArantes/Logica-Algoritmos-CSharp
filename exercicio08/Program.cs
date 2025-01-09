// Peça três lados de um triangulo e retorne o seu tipo:

// Equilatero: todos os lados congruentes;
// isosceles: dois lados congruentes;
// Escaleno: todos os lados com medidas distintas.


Console.WriteLine("Informe o lado direito");
int ladoDireito = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o lado inferior ");
int ladoInferior = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o lado esquerdo");
int ladoEsquerdo = Convert.ToInt16(Console.ReadLine());


if(ladoDireito == ladoInferior && ladoInferior == ladoEsquerdo)
{
  Console.WriteLine("Equilatero");
}
else if(ladoDireito == ladoInferior || ladoDireito == ladoEsquerdo || ladoInferior == ladoEsquerdo)
{
  Console.WriteLine("Isosceles");
}
else 
{
  Console.WriteLine("Escaleno");
}