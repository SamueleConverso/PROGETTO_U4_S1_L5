using System.Globalization;
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

Console.Write("Inserisci la tua data di nascita (GG/MM/AAAA): ");
var dataNascita = Console.ReadLine();
string pattern = "dd/MM/yyyy";
dataNascita = dataNascita!.Trim();
bool isDataNascitaInt = int.TryParse(dataNascita, out _);
bool isDataNascitaDeci = decimal.TryParse(dataNascita, out _);
bool isDataNascitaValid = DateTime.TryParseExact(dataNascita, pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

while (dataNascita == null || dataNascita == "" || dataNascita == " " || isDataNascitaInt || isDataNascitaDeci || !isDataNascitaValid) {
    Console.WriteLine();
    Console.WriteLine("La data di nascita non è valida!");
    Console.Write("Inserisci la tua data di nascita (GG/MM/AAAA): ");
    dataNascita = Console.ReadLine();
    dataNascita = dataNascita!.Trim();
    isDataNascitaInt = int.TryParse(dataNascita, out _);
    isDataNascitaDeci = decimal.TryParse(dataNascita, out _);
    isDataNascitaValid = DateTime.TryParseExact(dataNascita, pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
}

Console.Write("Inserisci il tuo codice fiscale: ");
var codiceFiscale = Console.ReadLine();
string regexCF = @"^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$";
codiceFiscale = codiceFiscale!.Trim();
bool isCodiceFiscaleInt = int.TryParse(codiceFiscale, out _);
bool isCodiceFiscaleDeci = decimal.TryParse(codiceFiscale, out _);
bool isCodiceFiscaleValid = System.Text.RegularExpressions.Regex.IsMatch(codiceFiscale, regexCF);

while (codiceFiscale == null || codiceFiscale == "" || codiceFiscale == " " || isCodiceFiscaleInt || isCodiceFiscaleDeci || !isCodiceFiscaleValid) {
    Console.WriteLine();
    Console.WriteLine("Il codice fiscale non è valido!");
    Console.Write("Inserisci il tuo codice fiscale: ");
    codiceFiscale = Console.ReadLine();
    codiceFiscale = codiceFiscale!.Trim();
    isCodiceFiscaleInt = int.TryParse(codiceFiscale, out _);
    isCodiceFiscaleDeci = decimal.TryParse(codiceFiscale, out _);
    isCodiceFiscaleValid = System.Text.RegularExpressions.Regex.IsMatch(codiceFiscale, regexCF);
}

Console.Write("Inserisci il tuo sesso (M/F/X): ");
var sesso = Console.ReadLine();
sesso = sesso!.Trim();
sesso = sesso.ToUpper();
bool isSessoMFX = sesso == "M" || sesso == "F" || sesso == "X";
bool isSessoInt = int.TryParse(sesso, out _);
bool isSessoDeci = decimal.TryParse(sesso, out _);

while (sesso == null || sesso == "" || sesso == " " || isSessoInt || isSessoDeci || !isSessoMFX) {
    Console.WriteLine();
    Console.WriteLine("Il sesso non è valido!");
    Console.Write("Inserisci il tuo sesso (M/F/X): ");
    sesso = Console.ReadLine();
    sesso = sesso!.Trim();
    sesso = sesso.ToUpper();
    isSessoMFX = sesso == "M" || sesso == "F" || sesso == "X";
    isSessoInt = int.TryParse(sesso, out _);
    isSessoDeci = decimal.TryParse(sesso, out _);
}


Console.Write("Inserisci il tuo comune di residenza: ");
var comuneResidenza = Console.ReadLine();
comuneResidenza = comuneResidenza!.Trim();
bool isComuneResidenzaInt = int.TryParse(comuneResidenza, out _);
bool isComuneResidenzaDeci = decimal.TryParse(comuneResidenza, out _);

while (comuneResidenza == null || comuneResidenza == "" || comuneResidenza == " " || isComuneResidenzaInt || isComuneResidenzaDeci) {
    Console.WriteLine();
    Console.WriteLine("Il comune di residenza non è valido!");
    Console.Write("Inserisci il tuo comune di residenza: ");
    comuneResidenza = Console.ReadLine();
    comuneResidenza = comuneResidenza!.Trim();
    isComuneResidenzaInt = int.TryParse(comuneResidenza, out _);
    isComuneResidenzaDeci = decimal.TryParse(comuneResidenza, out _);
}

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
Console.WriteLine();
Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
Console.WriteLine($"nato il: {contribuente.DataNascita} ({contribuente.Sesso}),");
Console.WriteLine($"residente a: {contribuente.ComuneResidenza}.");
Console.WriteLine($"Codice fiscale: {contribuente.CodiceFiscale}");
Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale} euro");
Console.WriteLine();
Console.WriteLine($"IMPOSTE DA VERSARE: {imposte} euro");
