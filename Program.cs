using System;

namespace Taryfikator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int predkoscjazdy, mandat;
                int pwsz = 20;      //Prędkość dopuszczalna pojazdu lub zespołu pojazdów w strefie zamieszkania.
                int pwoz = 50;      //Prędkość w terenie zabudowanym.
                int pptz = 90;      //Prędkość poza terenem zabudowanym.
                int pndej = 100;    //Prędkość na drodze ekspresowej jednojezdniowej oraz na drodze dwujezdniowej co
                                    //najmniej o dwóch pasach przeznaczonych dla każdego kierunku ruchu.
                int pnded = 120;    //Prędkość na drodze ekspresowej dwujezdniowej.
                int pna = 140;      //Prędkość na autostradzie.


                int wybor, pin = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wprowadz pin, żeby zalogować się do taryfikatora. Twój kod  do taryfikatora to 0. ");
                Console.ResetColor();
                pin = int.Parse(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Witamy w taryfikatorze mandatów.\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zatwierdzenie wyborów mandatów odbywa się poprzez wpisanie liczby!! W konsole.\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Taryfiikator obejmuje mandaty dla samochodów osobowych.\n");
                    Console.WriteLine("1. Mandaty w strefie zamieszkania. \n");
                    Console.WriteLine("2. Mandaty w terenie zabudowanym.\n");
                    Console.WriteLine("3. Mandaty poza terenem zabudowanym.\n");
                    Console.WriteLine("4. Mandaty na drodze ekspresowej jednojezdniowej.\n");
                    Console.WriteLine("5. Mandaty na drodze ekspresowej.\n");
                    Console.WriteLine("6. Mandaty na autostradzie.\n");
                    Console.WriteLine("7. Wyjdź z taryfikatora. \n");
                    Console.ResetColor();
                    Console.WriteLine("-------------------\n\n");
                    Console.WriteLine("Proszę wybrać jedną z powyższych opcji wpisujac numer na klawiaturze. : ");
                    wybor = int.Parse(Console.ReadLine());
                    switch (wybor)
                    {
                        case 1:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                if (pwsz > 20)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 50 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pwsz > 20);
                            mandat = predkoscjazdy - pwsz;

                            if (predkoscjazdy > pwsz)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Kierowca przekroczył dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pwsz < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, którzy przekroczy dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością. ");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                if (pwoz > 50)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 140 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pwoz > 50);
                            mandat = predkoscjazdy - pwoz;

                            if (predkoscjazdy > pwoz)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Przekroczyłeś dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych.");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pwoz < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, któy przekroczył dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością. ");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                ;
                                if (pptz > 90)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 140 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pptz > 90);
                            mandat = predkoscjazdy - pptz;

                            if (predkoscjazdy > pptz)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Przekroczyłeś dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych.");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pptz < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, który przekroczył dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością ");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                if (pndej > 100)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 140 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pndej > 100);
                            mandat = predkoscjazdy - pndej;

                            if (predkoscjazdy > pndej)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Przekroczyłeś dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych.");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pndej < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, który przekroczył dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością. ");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                if (pnded > 120)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 140 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pnded > 120);
                            mandat = predkoscjazdy - pnded;

                            if (predkoscjazdy > pnded)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Przekroczyłeś dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych.");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pnded < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, który przekroczył dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością. ");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Podaj prędkość z jaką pojazd się poruszał:");
                            predkoscjazdy = int.Parse(Console.ReadLine());
                            do
                            {
                                if (pna > 140)
                                    Console.WriteLine("Maksymalna prędkość w Polsce wynosi 140 km/h! Podaj maksymalną prędkość jeszcze raz.");
                                else
                                {
                                    break;
                                }
                            } while (pna > 140);
                            mandat = predkoscjazdy - pna;

                            if (predkoscjazdy > pna)
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine($"Przekroczyłeś dozwoloną prędkość o {mandat} km/h.");

                                {

                                    if (mandat < 11) Console.WriteLine("Mandat wynosi 50 zlotych i 0 pkt karnych.");
                                    else if (mandat < 21) Console.WriteLine("Mandat wynosi od 50 do 100 zlotych i 2 punkty karne.");
                                    else if (mandat < 31) Console.WriteLine("Mandat wynosi od 100 do 200 zlotych i 4 punty karne.");
                                    else if (mandat < 41) Console.WriteLine("Mandat wynosi od 200 do 300 złotych i 6 punktów karnych.");
                                    else if (mandat < 51) Console.WriteLine("Mandat wynosi od 300 do 400 zlotych i 8 punktów karnych.");
                                    else if (mandat >= 51)
                                    {
                                        Console.WriteLine("Mandat wynosi od 400 do 500 zlotych i 10 punktów karnych.");
                                        if (pna < 51)
                                        {
                                            Console.WriteLine("UWAGA!");
                                            Console.WriteLine("Prawo jazdy zostanie zatrzymane na trzy miesiące kierowcy, który przekroczył dopuszczalną prędkość o ponad 50 km/h w ternie zabudowanym.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n");

                                Console.WriteLine("Jedziesz z przepisową prędkością. ");
                            }
                            break;

                        case 7:
                            Console.WriteLine("Życzymy miłego dnia.");
                            return;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (!int.TryParse(Console.ReadLine(), out int input))

                return;
            }
        }

        
    }
}
