//Enrick De Munter 5ITN nr3 18/1/2020 brandstofkost
/*
 * OPGAVE
 * ======
 * we willen brandstofkost berekenen daarvoor hebben we de soort brandstof nodig(B7/E5/E10)
 * Bij elke tankbeurt geeft de gebruiker zijn km stand en het aantal liter
 * Het aantal liter per km, net als de prijs.
 * Diesel of benzine        diesel = 1.5900
 *                          super 95 = 1.5140
 *                          super 97 = 1.6020
 *
 * Aantal getankte liters
 * liters over
 * km stand
 *
 * VRAAG    rijd u met DIESEL, super 95 of super 97
 *           Wat is uw kilometerstand
 *          HVL   liter heeft u getankt
 *          HVL   liter heeft u over
 *         
 *          
 * BEREKEN    ALS diesel
 *                               DAN  Verbruik = aantalkilometers/liter
 *                                 som1 = aantalKil / verbruik                       
 *                                 som 2= som1 * 1,59
 *            ALS super95
 *                               DAN  Verbruik = aantalkilometers/liter
 *                                  som1 = aantalKil / verbruik                       
 *                                  som 2= som1 * 1,5140   
 *            ALS super97
 *                               DAN  Verbruik = aantalkilometers/liter
 *                                  som1 = aantalKil / verbruik                       
 *                                  som 2= som1 * 1,6020
 *             
 * TOON     de brandstofkost som2               
 *
 *
 *
 *
 */





using System;



namespace Brandstofkost

{



    class MainClass

    {



        public static void Main(string[] args)

        {

            //variabelen

            ushort soort = 0, Diesel = 1, super95 = 2, super97 = 3;
            ushort som1;
            decimal som2;
            int somKilometstand = 0, aantalKilometer, vorigAantalKilometer = 0;
            byte aantaLiterGetankt, aantalLiterOver, verbruik, somLiter;


            Console.WriteLine("voor u deze toepassing kan beginnen moeten wij u kilometerstand voor deze tankbeurt weten?");
            vorigAantalKilometer = int.Parse(Console.ReadLine());


            // VRAAG    rijd u met DIESEL typ 1, super 95 typ 2 of super 97 typ3
            Console.WriteLine("rijd u met DIESEL typ 1, super 95 typ 2 of super 97 typ3");
            soort = ushort.Parse(Console.ReadLine());
            while (soort < 4)
            {
                aantalKilometer = 0;
                //          wat is uw kilometer stand?
                Console.WriteLine("wat is uw kilometer stand");
                aantalKilometer = int.Parse(Console.ReadLine());
                //          HVL   liter heeft u getankt
                Console.WriteLine("hvl liter heeft u getankt");
               aantaLiterGetankt = byte.Parse(Console.ReadLine());

                //          HVL   liter heeft u over

                Console.WriteLine("hvl liter heeft u over");

                aantalLiterOver = byte.Parse(Console.ReadLine());

                somKilometstand = aantalKilometer - vorigAantalKilometer;

                somLiter = (byte)(aantaLiterGetankt - aantalLiterOver);
                Console.WriteLine($"het aantal liters verbruikt: {somLiter}");
                Console.WriteLine($"het aantal km sinds laatste rit:{somKilometstand}");

                // BEREKEN      ALS diesel
                //              DAN  Verbruik = aantalkilometers/liter
                //                  som1 = aantalKil / verbruik                       
                //                   som 2= som1 * 1,59
                if (soort == Diesel)
                {
                    verbruik = (byte)(somKilometstand / somLiter);
                    som1 = (ushort)(somKilometstand / verbruik);
                    som2 = (decimal)(som1 * 1.59);

                    Console.WriteLine($"uw brandstof kost is:{som2}EUR");
                }
                // BEREKEN      ALS diesel
                //              DAN  Verbruik = aantalkilometers/liter
                //                  som1 = aantalKil / verbruik                       
                //                   som 2= som1 * 1,5140

                if (soort == super95)
                {
                    verbruik = (byte)(somKilometstand / somLiter);
                    som1 = (ushort)(somKilometstand / verbruik);
                    som2 = (decimal)(som1 * 1.5140);

                    Console.WriteLine($"uw brandstof kost is:{som2}EUR");

                }

                // BEREKEN      ALS diesel

                //              DAN  Verbruik = aantalkilometers/liter
                //                  som1 = aantalKil / verbruik                       
                //                   som 2= som1 * 1,6020

                if (soort == super97)
                {
                    verbruik = (byte)(somKilometstand / somLiter);
                    som1 = (ushort)(somKilometstand / verbruik);
                    som2 = (decimal)(som1 * 1.6020);
                    Console.WriteLine($"uw brandstof kost is:{som2}EUR");

                }

                vorigAantalKilometer = aantalKilometer;

            }

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }

    }

}