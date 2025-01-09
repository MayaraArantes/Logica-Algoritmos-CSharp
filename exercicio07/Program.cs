// Peça tres numeros inteiro e retorne qual deles é o menor.


Console.WriteLine("Informe o primeiro número: ");
int numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
int numero2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o terceiro número: ");
int numero3 = Convert.ToInt16(Console.ReadLine());

int menor = numero1;

if(numero2 < menor)
{
  menor = numero2;
}

if(numero3 < menor)
{
  menor = numero3;
}


Console.WriteLine($"O menor número é: {menor} ");


