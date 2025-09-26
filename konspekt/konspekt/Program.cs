

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

