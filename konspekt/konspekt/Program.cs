

//1.  tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("tere kasutaja, mis su nimi on");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("sa ei sisstanud enda mine😭");
}
else if (nimi != "")

{
    Console.WriteLine("tere " + nimi + "🍆"); 
}
else
{
    Console.WriteLine("tundmatu sisestus");
}
//2- vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust peasastatud ifide abil
/* if (kasutajavanus > 0)
        {
    if (kasutajavanus < 18)

    {
        Console.WriteLine("emerksi ei saa, alakas, poest valja (┬┬﹏┬┬)");
    }
    else
    {
        Console.WriteLine("naudi enda sydamerabandust ^o^");
    }
}
*/
//2.2 mitu tingimust kasutades loogilist tehet "and"

if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("enerksi ei saa, alakas, poest välja marakratt ╰(*°▽°*)╯");
}
else
{
    Console.WriteLine("oled piisavalt vana, et enda vedel sydamerabandust osta");
}

//2.3 mitu vahemiku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"sisesta oma pikkus ka {nimi}");
double kasutajapikkus = double.Parse(Console.ReadLine());
if (kasutajapikkus < 1.00d)
{
    Console.WriteLine("oled midget T_T");

}
else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
{
    Console.WriteLine("naise pikkus noormehe kohta,(┬┬﹏┬┬) " + nimi);
}
else if (kasutajapikkus < 1.50d && kasutajapikkus >= 1.25d)
{
    Console.WriteLine("Aasiapärane pikkus eesti mehe kohta, läheb paremaks aga ikka lyhike ");
}
else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.50d)
{
    Console.WriteLine("Oled juba päris hea pikkusega, alla eesti mehe keskmise aga palju parem");
}
else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)

{
    Console.WriteLine("norm vend oled, päris pikk");
}


int arv1 = 0;
int arv2 = 0;
Console.WriteLine("tere, palun sisestage esimene arv:");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("sisestage teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("missugust tehet soovid teha? kirjuta kas + - / * ^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+" /* tingimus siia*/)

{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-"/* tingimus siia*/)

{
    tehe = arv1 - arv2;

}
if (tehtetüüp == "*"/* tingimus siia*/)

{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "/"/* tingimus siia*/)
{
    tehe = arv1 / arv2;
}
if (tehtetüüp == "^"/* tingimus siia*/)
{
    tehe = (int)Math.Pow(arv1, arv2);
}
Console.WriteLine($"{tehtetüüp} tehte tulemus: {tehe}");





//4 parool, if ja string andmetüüp

Console.WriteLine($"palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("rahuldav parool");

}
else if (password == "saatana"  || password == "1234")
{
    Console.WriteLine("parool on sobimatu, see sinu parool kindlasti ei ole.");

}
else
{
    Console.WriteLine("parool on vale");

}

//5 värvitavus
Console.WriteLine("mis on sinu lemmik värv?");
string favcolour = Console.ReadLine();
if (favcolour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favcolour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}else if (favcolour == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}else if (favcolour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}else if (favcolour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}else if (favcolour == "hall")
{
    Console.BackgroundColor = ConsoleColor.Gray;
}else if (favcolour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}else if (favcolour == "tume sinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}else if (favcolour == "pruun")
{
    Console.WriteLine("seda värvi pole");
}else if (favcolour == "lilla")
{
    Console.WriteLine("seda värvi pole");
}else if (favcolour == "roosa")
{
    Console.WriteLine("seda värvi pole");
}else if (favcolour == "oranz")
{
    Console.WriteLine("seda värvi pole");
}else if (favcolour == "helesinine")
{
    Console.WriteLine("seda värvi pole");
}
Console.WriteLine("siin su värv (❁´◡`❁)");
/* Meetodid
meetodid on väljakutsutavad koodijadad. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
meetodid lasevad programmeerijal taaskasutada ome eelnevalt kirjutatud koodi - write once us many times
meetodeid on kahte liiki- ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta midagi, kuid omavad siiski mingit tegevust

Meetodi signatuur:
meetodi signatuu koosneb mitmest kindlalt äramääratud omadusest, nendeks on:
-juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodilejuurde pääseda saab
public- meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub
private- meetod on saadav ainult selles klassis, kus meetod ise asub
protected- meetod on saadaval ainultselles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus sellele klassile
internal- meetod on saadaval ainult selles klassis ja ainult selles failis.
võibolla ka pandud static- meetod kuulub selle klassi juurde
tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta
andmetüüp mida tagastada võibolla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta üldse andmeid
pannakse selle asemel andmetüübiks "void". kui meetodil on tagastustüüp mis on midagi muud kui void
on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb,et just see, on vaja
väljakutseasukota tagastada, ning peale returni on muutuja nimi tagastatava infoga. peale return lauset, ei
teostata mitte ühtegi muud meetodi sisu. return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö

1. tüüpi meetod- ei tagasta midagi
public static void uusmeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static"  ütleb et ta on
selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta ning pärast meetodi omadusi on meetodi nimi uusmeetod
peale mida on sulus, kus parameetreid ei ole
pärast signatuuri on koodiplokk meetodi koodiga {}
console.writeline("tere"); antud juhul metod kuvab konsooli sõnumi

2. tüüpi meetod- tagastab väärtuse
int[] arvutatudarvud = new int[] {3, 67, 420}; töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega "arvutatudarvud"
public static int arvutakokku(int[] arvud)
meetod, mille signatuuris on juurdepääsumodifikaator public, static ütleb et meetod kuulub siia klassi, tagastustüüp int ütleb,
et programmis väljakutseasukohta tagastatakse täisarv, peale seda on meetodi nimi "arvutakokku" ning sulgude vahel ootab meetod täisarvumassiivi
millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on koodiplokk {} tehtava koodiga
int summa = 0; tekitatakse täisarvuandmetüüpi muutuja nimega summa, kuhu esialgu omistatakse arv 0.
foreach (int  i in arvud) foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi

summa += i; ja muutujale summa lisatakse juurde, hetkel käidav element.

return summa; pärast tsükli töö lõppu tagastatakse return käsu abil, muutuja summa sisu.

 */

//string lause = "Tere  hommikust, mul on monster otsas, kas ma võin veel magada?";
//Console.WriteLine("lause pikkus on: " + lause.Length);
//Console.WriteLine("see tekst on capslockis:" + lause.ToUpper());
//Console.WriteLine("see tekst on väiketähtedes:" + lause.ToLower());
//Console.WriteLine("kas lauses on sõna \"magada\"?:" + lause.ToLower().Contains("magada"));
/*
List<string> list = new List<string>() { "auto", "kraav", "kruus" };
string listkoos = "";
foreach (var sõne in list)
{
    listkoos += ("" + sõne.ToUpper() + ",");
}
Console.WriteLine(listkoos);

string eesnimi = "Julius";
string perekonnanimi = "Caesar";
string amet = "Ohver";
string kuuluskeiser = string.Concat(eesnimi, perekonnanimi, amet);
Console.WriteLine(kuuluskeiser);


string kuulukeiser2 = $"{eesnimi}, {perekonnanimi}, {amet}.";
Console.WriteLine($"{eesnimi}, {perekonnanimi}, {amet}.");
Console.WriteLine(kuulukeiser2);
*/
/*
string[] sõnadlauses = lause.Split(' ');
foreach (var sõne in sõnadlauses) ;
{
    Console.WriteLine(sõne);
}
string ükssõna = "kuulilennuteetunneliluuk";
Console.WriteLine(ükssõna[4]);
Console.WriteLine(ükssõna.IndexOf("i"));
*/
//Console.WriteLine("\" ");

//Console.WriteLine(" a\nb ");

//Console.WriteLine("AAAAA");


    