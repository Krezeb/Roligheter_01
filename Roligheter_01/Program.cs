using System;

namespace Roligheter_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string myName = "", myYrke = "";
            int myAge = 0;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Roligheter 01");
                Console.WriteLine("-------------\n");
                Console.WriteLine("Välj ett av följande alternativ: ");
                Console.WriteLine("1: Ange Namn");
                Console.WriteLine("2: Ange Ålder och Yrke");
                Console.WriteLine("3: Matte");
                Console.WriteLine("\n");
                Console.WriteLine("0: Avsluta");

                string huvudMeny = Console.ReadLine();
                bool menyLoop = true;

                switch (huvudMeny)

                {
                    case "1":
                        while (menyLoop)
                        {
                            Console.Clear(); // Rensar Konsollen
                            Console.WriteLine("Uppgift 1 - Namn");
                            Console.WriteLine("----------------\n");
                            Console.Write("Ange ditt namn: "); //Console.Write kan man använda istället för WriteLine om man vill ha Readline på samma rad
                            myName = Console.ReadLine();
                            Console.WriteLine("Ditt namn är {0}. Är detta korrekt? (Ja/Nej) ", myName); //Placeholders
                            string menyValEtt = Console.ReadLine().ToLower(); // svaret till frågan ovan konverteras till Lowercase för att förenkla menyn

                            if (menyValEtt == "ja" || menyValEtt == "j")
                            {
                                menyLoop = false; //Bryter loss ur Namn loopen och återgår till huvudmenyn
                            }
                            else
                            {
                                menyLoop = (true); //Fortsätter Namn loopen
                            }
                        }
                        break;

                    case "2":
                        while (menyLoop)
                        {
                            Console.Clear(); // Rensar Konsollen
                            Console.WriteLine("Uppgift 2 - Ålder och Yrke");
                            Console.WriteLine("--------------------------\n");
                            Console.Write("Ange din Ålder: ");
                            myAge = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ange din Yrke: ");
                            myYrke = Console.ReadLine();

                            Console.WriteLine($"Din ålder är {myAge} och du jobbar som {myYrke}.\n"); //Interpolation     
                            Console.Write("Är detta korrekt? (Ja/Nej) ");
                            string menyValEtt = Console.ReadLine().ToLower(); // svaret till frågan ovan konverteras till Lowercase för att förenkla menyn

                            if (menyValEtt == "ja" || menyValEtt == "j")
                            {
                                menyLoop = false; //Bryter loss ur Namn loopen och återgår till huvudmenyn
                            }
                            else
                            {
                                menyLoop = (true);
                            }
                        }
                        break;

                    case "3":
                        while (menyLoop)
                        {
                            Console.Clear(); // Rensar Konsollen
                            double svar = 0;

                            Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.Write("Siffra Ett: "); double myNumOne = double.Parse(Console.ReadLine());
                            Console.Write("Funktion  : "); string myFunction = Console.ReadLine();
                            Console.Write("Siffra Två: "); double myNumTwo = Convert.ToDouble(Console.ReadLine());

                            if (myFunction == "/")
                            {
                                svar = myNumOne / myNumTwo;
                            }

                            else if (myFunction == "*")
                            {
                                svar = myNumOne * myNumTwo;
                            }

                            else if (myFunction == "-")
                            {
                                svar = myNumOne - myNumTwo;
                            }

                            else if (myFunction == "+")
                            {
                                svar = myNumOne + myNumTwo;
                            }
                           
                            Console.Clear(); // Rensar Konsollen
                            Console.WriteLine($"{myNumOne} {myFunction} {myNumTwo} = {svar}\n");
                            Console.WriteLine("1: Ny beräkning");
                            Console.WriteLine("0: Återgå till huvudmenyn");
                            string miniCont = Console.ReadLine();

                            switch (miniCont)
                            {
                                case "1":
                                    break;

                                case "0":
                                    menyLoop = false;
                                    break;
                            }

                        }
                        break; //Avslutar Programmet

                    case "0":
                            isRunning = false;
                        break;

                    default:
                        while (menyLoop)
                        {
                            Console.Clear(); // Rensar Konsollen
                            Console.WriteLine("Felaktig Input. Var god försök igen.\n");
                            Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
                            string miniCont = Console.ReadLine();

                            switch (miniCont)
                            {
                                default:
                                    menyLoop = false;
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
