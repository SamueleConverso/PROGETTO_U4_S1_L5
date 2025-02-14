using PROGETTO_U4_S1_L5.Models;

Console.WriteLine("Benvenuto nel programma di calcolo delle imposte!");
Console.WriteLine();
Console.Write("Inserisci il tuo nome: ");
var nome = Console.ReadLine();
Console.Write("Inserisci il tuo cognome: ");
var cognome = Console.ReadLine();
Console.Write("Inserisci la tua data di nascita: ");
var dataNascita = Console.ReadLine();
Console.Write("Inserisci il tuo codice fiscale: ");
var codiceFiscale = Console.ReadLine();
Console.Write("Inserisci il tuo sesso: ");
var sesso = Console.ReadLine();
Console.Write("Inserisci il comune di residenza: ");
var comuneResidenza = Console.ReadLine();

Console.Write("Inserisci il tuo reddito annuale: ");
bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal redditoAnnuale);
while (!isDecimal) {
    Console.WriteLine();
    Console.WriteLine("Il reddito annuale deve essere un numero!");
    Console.Write("Inserisci il tuo reddito annuale: ");
    isDecimal = decimal.TryParse(Console.ReadLine(), out redditoAnnuale);
}

Console.WriteLine();

Contribuente contribuente = new Contribuente(nome!, cognome!, dataNascita!, codiceFiscale!, sesso!, comuneResidenza!, redditoAnnuale);

decimal imposte = contribuente.CalcolaImposte();

Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
Console.WriteLine($"nato il: {contribuente.DataNascita} ({contribuente.Sesso}),");
Console.WriteLine($"residente a: {contribuente.ComuneResidenza}.");
Console.WriteLine($"Codice fiscale: {contribuente.CodiceFiscale}");
Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale} euro");
Console.WriteLine();
Console.WriteLine($"IMPOSTE DA VERSARE: {imposte} euro");
