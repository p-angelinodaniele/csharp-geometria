

Console.Write("Inserisci il nome del rettangolo: ");
string nomeRettangolo = (Console.ReadLine());
Console.Write("Inserisci la base del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza del rettangolo: ");
int altezzaRettangolo = int.Parse(Console.ReadLine());




Rettangolo r1 = new Rettangolo(nomeRettangolo ,baseRettangolo, altezzaRettangolo);

r1.CalcolaArea();
r1.CalcolaPerimetro();
r1.stampaRettangolo();