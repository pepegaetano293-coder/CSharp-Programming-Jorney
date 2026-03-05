using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Text;

namespace CorsoCSharp
{
    internal class Metodi_e_array
    {
        static void Main(string[] args)
        {
            // Esercizio (2)
            // Crea un metodo Saluta.
            // Senza parametri: Stampa "Ciao!"
            // Con un parametro string nome: stampa "Ciao, [nome]!"
            // Con "string nome" e "int ora: Se l'ora è < 12 stampa "Buongiorno,[nome]!"
            // Se, invece, è >=12 e <=17 stampa "Buon pomeriggio, [nome]!"
            // Altrimenti stampa: "Buonasera, [nome]!"

            Console.WriteLine(Saluta());
            Console.WriteLine(Saluta("Gaetano"));
            Console.WriteLine(Saluta("Gaetano", 8.30));
            Console.WriteLine(Saluta("Gaetano", 15.00));
            Console.WriteLine(Saluta("Gaetano", 21.00));


            // ------------------------------------------------------- //

            // Esercizio (1) Calcolatore di Aree.
            // Crea una classe che contenga un metodo chiamato CalcolaArea.
            // Versione 1: Accetta un "double" (lato) e restituisce l'area di un quadrato (lato^2).
            // Versione 2: Accetta due "double" (base, altezza) e restituisce l'area del rettangolo (base * altezza)
            // Versione 3: Accetta un double (raggio) e un bool (isCerchio). Se il bool è TRUE,
            // restituisce l'area del cerchio (pigreco * raggio^2).

            Console.WriteLine($"Il lato del quadrato è {CalcoloArea(3.5)}");
            Console.WriteLine($"L'area del rettangolo è pari a {CalcoloArea(2.7, 4.1)}");
            Console.WriteLine($"Larea del cerchio è pari a {CalcoloArea(4.2, false)}");

            // ----------------------------------------------------- //


            // Esercizio (3) Analisi temperatura.
            // Crea un array di 7 "double" che rappresenti le temperature di una settimana.
            // 1. Popola l'array tramite l'input dell'utente (Console.ReadLine).
            // 2. Crea un metodo che accetti l'array e restituisca la media delle temperature.
            // 3. Trova la temperatura massima e quella minima usando un ciclo "foreach".

            double[] temperatura = new double[7];

            // Uso il primo valore dell'array come PUNTO DI PARTENZA.
            double massimo = temperatura[0];
            double minimo = temperatura[0];

            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.WriteLine($"Inserisci la temperatura per il giorno {i + 1}: ");
                string input = Console.ReadLine();
                temperatura[i] = double.Parse(input);
            }
            foreach (double temp in temperatura)
            {
                if (temp > massimo)
                {
                    massimo = temp; // <- Si trova il nuovo punto massimo
                }
                if (temp < minimo)
                {
                    minimo = temp; // <- Si trova il nuovo punto minimo
                }
            }
            Console.WriteLine($"La temperatura massima è {massimo} mentre la minima è {minimo}");

            // ---------------------------------------------------- //

            // Esercizio (4) La matrice Voti
            // Immagina una classe con 3 studenti e 4 materie. Crea una matrice int[3, 4].
            // (1) Riempi la matrice con numeri casuali (voti da 1 a 10) usando due ciclo for annidati.
            // (2) Stampa la matrice in forma tabellare.
            // (3) Usa un ciclo foreach per contare quante sufficiente (voti >=6) ci sono in totale nella classe.

            int[,] voti = new int[3, 4];
            Random generatore = new Random(); // <- Crea l'oggetto per i valori random


            for (int row = 0; row < voti.GetLength(0); row++)
            {
                for (int columns = 0; columns < voti.GetLength(1); columns++)
                {
                    voti[row, columns] = generatore.Next(1, 11);
                }
            }

            // Forma TABELLARE

            Console.WriteLine("\n--- Tabella Voti ---");
             for(int row = 0; row < voti.GetLength(0); row++)
             {
                for (int columns = 0; columns < voti.GetLength(1); columns++)
                {
                    Console.Write(voti[row, columns] + "\t"); // <-  \t Aggiunge una tabulazione per incollare bene i numeri
                }
                Console.WriteLine();
             }

            foreach (int voto in voti)
            {
                if (voto >= 6)
                {
                    Console.WriteLine($"I voti sufficienti sono i seguenti: {voto}");
                }
            }

            // Esercizio (5) Cubo di Array
            // Crea un array tridimensionale "int[2, 3, 3]" che rappresenti: 2 magazzini, con ognuno 3 scaffali, ognuno con 3 scatole
            // Assegna ad ogni scatola un valore che rappresenta il numero di oggetti contenuti.
            // scrivi un metodo che usi 3 cicli for annidati per stampare il contenuto:
            // Magazzino {i}, Scaffale {j}, Scatola {k}: {valore} oggetti"
            // Calcolare il totale degli oggetti in un detereminato magazzino scelto dall'utente:

            int[,,] magazzino = new int[2, 3, 3]
            {
                 {
                     {1,6,9},
                     {4,11,2},
                     {7,0,9},
                 },
                 {
                     {10,20,0},
                     {1,9,3},
                     {2,6,4},
                 },

            };

            for (int i = 0; i < magazzino.GetLength(0); i++)
            {
                for (int j = 0; j < magazzino.GetLength(1); j++)
                {
                    for (int k = 0; k < magazzino.GetLength(2); k++)
                    {
                        Console.WriteLine($"Magazzino {i}, Scaffale {j}, Scatola {k}: Valore {magazzino[i, j, k]}");
                    }
                }
            }

            Console.WriteLine("Scegli il numero del magazzino: (0 / 1)");
            int risposta;
            risposta = int.Parse(Console.ReadLine());
            int totaleMagazzino = 0; // <- Variabile per accumulare il totale

            for (int j = 0; j < magazzino.GetLength(1); j++)
            {
                for (int k = 0; k < magazzino.GetLength(2); k++)
                {
                    totaleMagazzino = totaleMagazzino + magazzino[risposta, j, k];
                }
            }
            Console.WriteLine($"La somma degli elementi in magazzino {risposta} è: {totaleMagazzino}");


            // Esercizio (6) Il Cinema
            // Crea un cinema con 2 sale, ogni sala ha 5 file, e ogni fila ha 10 posti.

            // Crea un array bool[2, 5, 10] dove "True" significa "posto occupato" e "false" significa "posto libero".
            // Riempy l'array casualmente o manualmente.
            // Chiedi all'utente il numero della sala (0 o 1) e conta qunati posti sono liberi in quella sala
            // EXTRA: Stampa la "mappa" della sala scelta (usa "x" per occupato e "O" per libero)


            bool[,,] cinema = new bool[2, 5, 10];
            Random generatore1 = new Random();

            Console.WriteLine("Scegli il cinema: (0 / 1)");
            int risposta1;
            risposta1 = int.Parse(Console.ReadLine());
            int totLiberi = 0;


            for (int i = 0; i < cinema.GetLength(0); i++)
            {
               for(int j = 0; j < cinema.GetLength(1); j++)
               {
                   for(int k = 0; k < cinema.GetLength(2); k++)
                   {
                        cinema[i, j, k] = generatore.Next(0, 2) == 0; // (0, 2) rappresentano il "limite superiore esclusivo".
                                                                      // Infatti, essa può dare valore 0 (incluso) e 2 (escluso), quindi
                                                                      // gli unici valori possibili che posso avere sono 0,1.
                                                                      // (0, 2) == 0 funziona così:
                                                                      // Il computer estrae un numero (0 oppure 1) e si chiede "Questo valore è uguale a 0?"
                                                                      // Se la risposta è "Sì", assegna "true" altrimenti "false". 
                        totLiberi = totLiberi + Convert.ToInt16(cinema[risposta1, j, k]);
                   }
               }
            }

            Console.WriteLine($"La somma dei posti occupati al cinema {risposta} è {totLiberi}");

            // MAPPA CINEMA //

            Console.WriteLine($"------ MAPPA SALA {risposta1} ------");
            Console.WriteLine("[X] = Posto occupato ; [O] = Posto libero");

            for (int file = 0; file < cinema.GetLength(1); file++)
            {
                Console.WriteLine($"Fila: {file}");
                for(int posti = 0; posti < cinema.GetLength(2); posti++)
                {
                    if (cinema[risposta1, file,posti] == true)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[O]");
                    }
                }
                Console.WriteLine(); // Dopo che finisce l'i-esima fila, vai a capo.
            }
        }

        // Esercizio (1)
        static double CalcoloArea(double num1)
        {
            return Math.Pow(num1, 2);
        }
        static double CalcoloArea(double num1, double num2)
        {
            return num1 * num2;
        }
        static double CalcoloArea(double num1, bool isCerchio)
        {
            if (isCerchio == true)
            {
                double risultato = 3.14 * Math.Pow(num1, 2);
                return risultato;
            }
            else
            {
                return 0;
            }

        }

        // Esercizio (2)
        static string Saluta()
        {
            return "Ciao!";
        }
        static string Saluta(string nome)
        {
            return ($"Ciao {nome}!");

        }
        static string Saluta(string nome, double numero)
        {
            if (numero < 12.00)
            {
                return $"Buongiorno, {nome}";

            }
            else if (numero >= 12.00 && numero <= 17.00)
            {
                return $"Buon pomeriggio, {nome}";

            }
            else
            {
                return $"Buonasera, {nome}";
            }
        }

    }
}
