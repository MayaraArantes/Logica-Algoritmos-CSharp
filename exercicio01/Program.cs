// Peça dois numeros inteiros, se forem iguais realize a soma, se foram diferentes realize a multip.

Console.WriteLine("Informe o primeiro número: ");
int numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
int numero2 = Convert.ToInt16(Console.ReadLine());


if(numero1 == numero2)
{
  Console.WriteLine(numero1 + numero2);
}
else
{
  Console.WriteLine(numero1 * numero2);
}