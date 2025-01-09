// Peça um numero e retorne se é par ou impar.

// Dica: para sabermos se um numero é par ou impar, será necessario utilizarmos o modulo %


Console.WriteLine("Informe um número: ");
int numero = Convert.ToInt16(Console.ReadLine());


// verificação com operador ternario
Console.WriteLine(numero % 2 == 0 ? "Par" : "Impar");