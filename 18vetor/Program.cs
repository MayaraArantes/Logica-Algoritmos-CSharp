// Vetor (ARRAYS)
string[] nomes = {"Mayara", "Lucinei", "Fernando", "Vanda"};


// Exibir nomes
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);



// caso tenha + de 500 nomes e não saiba qual posição o nome q vc procura estiver, pode fazer o loop para aparecer todos os nomes
for(int indice = 0; indice < 4; indice++)
{
  Console.WriteLine(nomes[indice]);
}