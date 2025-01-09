// Peça uma hora referente ao horario de Brasilia (0 até 23).
// Em seguida liste três cidades e peça para selecionar uma.
// Tendo essas duas informações, retorne o horário da cidade selecionada.

// Algumas cidade e seus respectivos fusos horarios:
// Toquio: +12
// Lisboa: +4
// Paris: +5


Console.WriteLine("Informe um horário de brasilia: ");
int hora = Convert.ToInt16(Console.ReadLine());


Console.WriteLine("Selecione uma cidade: ");
Console.WriteLine("1: Toquio");
Console.WriteLine("2: Lisboa");
Console.WriteLine("3: Paris");
int cidade = Convert.ToInt16(Console.ReadLine());


switch(cidade)
{
  case 1:
  hora+=12;
  break;

  case 2:
  hora+=4;
  break;

  default:
  hora+=5;
  break;
}

if(hora > 23)
{
  Console.WriteLine(hora - 24);
}
else
{
  Console.WriteLine(hora);
}