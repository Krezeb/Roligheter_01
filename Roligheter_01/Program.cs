using System;

namespace Roligheter_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string myName, myYrke = "", myAgeStr;
            int myAgeInt;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Roligheter 01");
                Console.WriteLine("-------------\n");
                Console.WriteLine("Välj ett av följande alternativ: ");
                Console.WriteLine("1: Ange Namn");
                Console.WriteLine("2: Ange Ålder och Yrke");
                Console.WriteLine("3: Matte\n");
                Console.WriteLine("0: Avsluta\n");
                Console.Write("Svar: ");
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
                            if (string.IsNullOrWhiteSpace(myName)) //Ifall man inte skriver nåt. IsNullOrWhiteSpace täcker även IsNullOrEmpty
                            {
                                Console.Clear();
                                Console.WriteLine("Uppgift 1 - Namn");
                                Console.WriteLine("----------------\n");
                                Console.WriteLine("Ett namn måste anges. Gör Om Gör Rätt.");
                                Console.WriteLine("Tryck på valfri knapp för att Göra Om och Göra Rätt...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Uppgift 1 - Namn");
                                Console.WriteLine("----------------\n");
                                Console.WriteLine("Ditt namn är {0}. Är detta korrekt? (Ja/Nej) \n", myName); //Placeholders
                                Console.Write("Svar: ");
                                string menyValEtt = Console.ReadLine().ToLower(); // svaret till frågan ovan konverteras till Lowercase för att förenkla menyn

                                if (menyValEtt == "ja" || menyValEtt == "j")
                                {
                                    menyLoop = false; //Bryter loss ur Namn loopen och återgår till huvudmenyn
                                }
                                else
                                {
                                    menyLoop = (true); //Loopar om
                                }
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
                            myAgeStr = Console.ReadLine();
                            bool agePass = int.TryParse(myAgeStr, out myAgeInt); //TryParse. Felmeddelande om det blir False
                            if (agePass == true)
                            {
                                bool miniLoop = true;
                                while (miniLoop)
                                {
                                    Console.Clear(); // Rensar Konsollen
                                    Console.WriteLine("Uppgift 2 - Ålder och Yrke");
                                    Console.WriteLine("--------------------------\n");
                                    Console.Write("Ange din Yrke: ");
                                    myYrke = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(myYrke)) //Ifall man inte skriver nåt. IsNullOrWhiteSpace täcker även IsNullOrEmpty
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Uppgift 2 - Ålder och Yrke");
                                        Console.WriteLine("--------------------------\n");
                                        Console.WriteLine("Yrke får inte vara tom. Gör Om Gör Rätt.");
                                        Console.WriteLine("Tryck på valfri knapp för att Göra Om och Göra Rätt...");
                                        Console.ReadLine();
                                    }

                                    Console.Clear();
                                    Console.WriteLine("Uppgift 2 - Ålder och Yrke");
                                    Console.WriteLine("--------------------------\n");
                                    Console.WriteLine($"Din ålder är {myAgeInt} och du jobbar som {myYrke}.\n"); //Interpolation     
                                    Console.WriteLine("Är detta korrekt? (Ja/Nej) \n");
                                    Console.Write("Svar: ");
                                    string menyValEtt = Console.ReadLine().ToLower(); // svaret till frågan ovan konverteras till Lowercase för att förenkla menyn

                                    if (menyValEtt == "ja" || menyValEtt == "j")
                                    {
                                        miniLoop = false;
                                        menyLoop = false; //Bryter loss ur Namn loopen och återgår till huvudmenyn
                                    }
                                    else
                                    {
                                        miniLoop = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Uppgift 2 - Ålder och Yrke");
                                Console.WriteLine("--------------------------1\n");
                                Console.WriteLine("Ogiltiga tecken. Gör Om Gör Rätt.");
                                Console.WriteLine("Tryck på valfri knapp för att Göra Om och Göra Rätt...");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case "3":
                        while (menyLoop)
                        {
                            double svar = 0.0;
                            string myFunctionStr = "", myNumOneStr = "", myNumTwoStr = "", miniContThree;
                            double myNumOneDoub = 0.0, myNumTwoDoub = 0.0;

                            Console.Clear(); // Rensar Konsollen
                            Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.Write("Siffra Ett: ");
                            myNumOneStr = Console.ReadLine();
                            bool numOnePass = double.TryParse(myNumOneStr, out myNumOneDoub);

                            if (numOnePass)
                            {
                                {
                                    Console.Write("Funktion  : ");
                                    myFunctionStr = Console.ReadLine();

                                    if (myFunctionStr == "/" || myFunctionStr == "*" || myFunctionStr == "-" || myFunctionStr == "+")
                                    {
                                        Console.Write("Siffra Två: ");

                                        myNumTwoStr = Console.ReadLine();
                                        bool myNumTwoPass = double.TryParse(myNumTwoStr, out myNumTwoDoub);

                                        if (myNumTwoPass)
                                        {
                                            
                                            if (myFunctionStr == "/")
                                            {
                                                svar = myNumOneDoub / myNumTwoDoub;
                                            }

                                            else if (myFunctionStr == "*")
                                            {
                                                svar = myNumOneDoub * myNumTwoDoub;
                                            }

                                            else if (myFunctionStr == "-")
                                            {
                                                svar = myNumOneDoub - myNumTwoDoub;
                                            }

                                            else if (myFunctionStr == "+")
                                            {
                                                svar = myNumOneDoub + myNumTwoDoub;
                                            }

                                            Console.Clear(); // Rensar Konsollen
                                            Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                                            Console.WriteLine("------------------------------------------------------\n");
                                            Console.WriteLine($"{myNumOneDoub} {myFunctionStr} {myNumTwoDoub} = {svar}\n");
                                            Console.WriteLine("1: Ny beräkning");
                                            Console.WriteLine("0: Återgå till huvudmenyn \n");
                                            Console.Write("Svar: ");
                                            miniContThree = Console.ReadLine();
                                            switch (miniContThree)
                                            {
                                                case "1":
                                                    menyLoop = true;
                                                    break;

                                                case "0":
                                                    menyLoop = false;
                                                    break;

                                                default:
                                                    Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                                                    Console.WriteLine("------------------------------------------------------\n");
                                                    Console.WriteLine("Felaktig Input (miniContThree)");
                                                    Console.WriteLine("Gör Om Gör Rätt.");
                                                    Console.ReadLine();
                                                    break;
                                            }
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                                            Console.WriteLine("------------------------------------------------------\n");
                                            Console.WriteLine("Siffra Två måste vara en siffra");
                                            Console.WriteLine("Felaktig Input (213). Gör Om Gör Rätt.");
                                            Console.ReadLine();
                                        }
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                                        Console.WriteLine("------------------------------------------------------\n");
                                        Console.WriteLine("Funktion måste vara en symbol: + - / *");
                                        Console.WriteLine("Felaktig Input (225). Gör Om Gör Rätt.");
                                        Console.ReadLine();
                                    }
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Uppgift 3 - Miniräknare (för att jag saknar fantasi!!)");
                                Console.WriteLine("------------------------------------------------------\n");
                                Console.WriteLine("Siffra Ett måste vara en siffra");
                                Console.WriteLine("Felaktig Input(237). Gör Om Gör Rätt.");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case "0":
                        isRunning = false;
                        break;

                    default:
                        Console.Clear(); // Rensar Konsollen
                        Console.WriteLine("Roligheter 01");
                        Console.WriteLine("-------------\n");
                        Console.WriteLine("Felaktig Input. Var god försök igen.\n");
                        Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}




