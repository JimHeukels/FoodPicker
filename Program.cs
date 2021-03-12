using foodPicker.Model;

using System;
using foodPicker.extensions;
using foodPicker.Services;

namespace foodPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var database = JsonLoadService.GetJson<Database>(@"Database\db.json");
            //var database2 = JsonLoadService.GetJson<string[]>(@"Database\db2.json");

            var x = new ReceptenService();

            int voorbeeld = 5;

            var y = x.GetRandomRecepten(7);
            foreach (var rec in y)
            {
                rec.Represent();
            }

            voorbeeld = 600;
        }
    }
}



//TODO
//  1) ReceptenKiezen:
//    ->Loop door lijst uit bestaanden recepten heen. Kies uit deze lijst vervolgens 7 unieke recepten. Verdeel deze 7 recepten over de 7 dagen van de week

//  2) Optie om recepten toe te voegen:
//    ->Optie om recepten toe te voegen aan de bestaande recepten lijst
//          ->Bij het toevoegen van nieuwe recepten de mogelijkheid bieden om gelijk ingredienten te kiezen die nodig zijn voor dit recept
//              ->Bij de ingredient keuze te mogelijkheid bieden om eventueel nieuwe ingredienten toe te voegen, zodat die in de toekomst gekozen kunnen worden

//  3) Reverse check
//    ->Mogelijkheid om aan te geven welke ingredienten je momenteel in huis hebt. Vervolgens deze lijst aan beschikbare ingredienten gebruiken om een lijst
//      recepten te outputten die je kan maken met de beschikbare ingredienten

//  4) ingredienten verschil
//    ->De functie van '3) Reverse check' om in te vullen welke ingredienten je hebt. Vervolgens deze lijst vergelijken met de lijst 
//      benodigde ingredienten van de '1) ReceptenKiezen' output. Het verschil in ingredienten (de ontbrekende ingredienten dus) vervolgens 
//      samenvatten in één lijst, a.k.a. een boodschappenlijst
