using System.ComponentModel.Design;

namespace ül
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KIRJUTA PROGRAMM MIS
            //KÜSIB KASUTAJALT TSÜKLIS,MILLISED MÄNGUD TALLE MEELDIVAD
            //küsimiste tulemus hoia järjndis
            List<string> mängud = new List<string>();
            Console.WriteLine("tere kasutaja, millised mängud sulle meeldivad");
            string mäng = "";
            while (mäng != "ei ole")
            {
                Console.WriteLine("paln sisestage järgmine mäng, kui ei ole, kirjuta \"ei ole\"");
                mäng = Console.ReadLine();
                mängud.Add(mäng);
            }
         
              foreach (var item in mängud)
            {
                Console.WriteLine(item);
            }

            if (mängud.Contains("mario kart")) ;
            {
                Console.WriteLine("kui vana sa oled??? mingi kuus vä?");
            }

            if (mängud.Contains("gta 6")) ;
            {
                Console.WriteLine("kust ajamasina said? kuidas rocksta arendusaega juurde sai?");
            }

            if (mängud.Contains("pong")) ;
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi, boomerite recall");
            }

            if(!mängud.Any())
            {
                Console.WriteLine("kas sulle ei meeldi mängud? vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
                    Console.WriteLine("aga miks sa siis ei sisestand");

                }
                else if (jahvõiei.Contains("ei"))
                {
                    Console.WriteLine("kahju");
                }
                else
                {
                    Console.WriteLine("ei saa aru :/");
                }



                //kirjuta programm kus on kaks kasutajat kasutajanime ja parooliga
                //küsi kasutajalt tema kasutajanime, otsi kasutajate järjendist vastav kasutaja ja kui kasutajat ei leita
                //ütle et kasutajat ei eksisteeri
                //kui kasutaja eksisteerib, vaata kasutaja parooli, küsi kasutajalt tema parool ja võrdle neid
                //kui paroolid ühivad, ütle tere tulemas
                //kui ei ühti küsi parooli uuesti

                List<List<string>> kasutajad = new List<List<string>>();
                kasutajad.Add(new List<string> { "kasutajanimi1", "parool1" });
                kasutajad.Add(new List<string> { "kasutajanimi2", "parool2" });
                // foreach (var item in kasutajad)
                // {
                //     Console.WriteLine(item.ToString() + "," + item[0] + "," + item[i]);
                // }
                string kasutajanimi = "";
                Console.WriteLine("palun sisesta oma kasutajanimi");
                kasutajanimi = Console.ReadLine();
                bool doesuserexist = false;
                string õigeparool = "";
                foreach (var user in kasutajad)
                {
                    if (user[0] == kasutajanimi)
                    {
                        doesuserexist = true;
                    }
                }
                if (doesuserexist == true)
                {
                    string sisestus = "";
                    Console.WriteLine("tere", kasutajanimi, "sisesta oma parool");
                    while (sisestus != õigeparool)
                    {
                        Console.WriteLine("palun sisesta enda parool");
                        sisestus = Console.ReadLine();

                    }
                    Console.WriteLine($"tere tulemast {kasutajanimi}");}
                else
                {
                    Console.WriteLine("kasutaja ei eksisteeri");
                }















                














            }















         //kui järjend sisaldab (.contains()) "mario kart" siis küsi kui vana ta on sarkastiliselt
         //kui järjend sisaldab "gta 6" siis küsi kust ta ajamasina sai, et rockstar lõpuks asjaga valmis sai
         //kui järjend  sisaldab "pong" siis ütle ""88ndad tahavad vanureid tagasi, toimub boomerite recall"
         //kui järjend on tühi, siis programm läheb edasi

            //küsi kasutajalt kas talle ei meeldi mängud ninglase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestust
            //.toupper() või .tolower()iga
            //kui talle ei meeldi, siis ütle,kahju
            //kui ta vastab jah, siis ütle, "aga miks siis ei sisestanud
            //kui vastus on midagi muud, siis ütle "ei saa aru:/"
        }
    }
}
