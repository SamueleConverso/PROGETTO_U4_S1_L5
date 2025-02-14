using PROGETTO_U4_S1_L5.Models;

Console.WriteLine("Benvenuto nel programma di calcolo delle imposte!");
Console.WriteLine();

Console.Write("Inserisci il tuo nome: ");
var nome = Console.ReadLine();
nome = nome!.Trim();
bool isNomeInt = int.TryParse(nome, out _);
bool isNomeDeci = decimal.TryParse(nome, out _);

while (nome == null || nome == "" || nome == " " || isNomeInt || isNomeDeci) {
    Console.WriteLine();
    Console.WriteLine("Il nome non è valido!");
    Console.Write("Inserisci il tuo nome: ");
    nome = Console.ReadLine();
    nome = nome!.Trim();
    isNomeInt = int.TryParse(nome, out _);
    isNomeDeci = decimal.TryParse(nome, out _);
}

Console.Write("Inserisci il tuo cognome: ");
var cognome = Console.ReadLine();
cognome = cognome!.Trim();
bool isCognomeInt = int.TryParse(cognome, out _);
bool isCognomeDeci = decimal.TryParse(cognome, out _);

while (cognome == null || cognome == "" || cognome == " " || isCognomeInt || isCognomeDeci) {
    Console.WriteLine();
    Console.WriteLine("Il cognome non è valido!");
    Console.Write("Inserisci il tuo cognome: ");
    cognome = Console.ReadLine();
    cognome = cognome!.Trim();
    isCognomeInt = int.TryParse(cognome, out _);
    isCognomeDeci = decimal.TryParse(cognome, out _);
}

Console.Write("Inserisci la tua data di nascita: ");
var dataNascita = Console.ReadLine();
dataNascita = dataNascita!.Trim();
bool isDataNascitaInt = int.TryParse(dataNascita, out _);
bool isDataNascitaDeci = decimal.TryParse(dataNascita, out _);

while (dataNascita == null || dataNascita == "" || dataNascita == " " || isDataNascitaInt || isDataNascitaDeci) {
    Console.WriteLine();
    Console.WriteLine("La data di nascita non è valida!");
    Console.Write("Inserisci la tua data di nascita: ");
    dataNascita = Console.ReadLine();
    dataNascita = dataNascita!.Trim();
    isDataNascitaInt = int.TryParse(dataNascita, out _);
    isDataNascitaDeci = decimal.TryParse(dataNascita, out _);
}

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

Console.WriteLine("CALCOLO DELLE IMPOSTE DA VERSARE:");
Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
Console.WriteLine($"nato il: {contribuente.DataNascita} ({contribuente.Sesso}),");
Console.WriteLine($"residente a: {contribuente.ComuneResidenza}.");
Console.WriteLine($"Codice fiscale: {contribuente.CodiceFiscale}");
Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale} euro");
Console.WriteLine();
Console.WriteLine($"IMPOSTE DA VERSARE: {imposte} euro");
