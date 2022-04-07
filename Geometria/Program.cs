using MieiRettangoli;

Console.Write("Inserisci il nome del primo rettangolo: ");
string nomeRettangolo1 = (Console.ReadLine());
Console.Write("Inserisci la base del primo rettangolo: ");
int baseRettangolo1 = int.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza del primo rettangolo: ");
int altezzaRettangolo1 = int.Parse(Console.ReadLine());


Console.Write("Inserisci il nome del secondo rettangolo: ");
string nomeRettangolo2 = (Console.ReadLine());
Console.Write("Inserisci la base del secondo rettangolo: ");
int baseRettangolo2 = int.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza del secondo rettangolo: ");
int altezzaRettangolo2 = int.Parse(Console.ReadLine());




Rettangolo r1 = new Rettangolo(nomeRettangolo1 ,baseRettangolo1, altezzaRettangolo1);
Rettangolo r2 = new Rettangolo(nomeRettangolo2, baseRettangolo2, altezzaRettangolo2);




r1.CalcolaArea();
r1.CalcolaPerimetro();
r1.stampaRettangolo();




r2.CalcolaArea();
r2.CalcolaPerimetro();
r2.stampaRettangolo();



r1.Disegna();

r2.Disegna();





