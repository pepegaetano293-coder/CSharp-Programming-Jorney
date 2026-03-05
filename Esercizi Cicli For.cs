using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp
{
    internal class Esercizi_Cicli_For
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //            // Esercizio (1) Tabellina personalizzata.
            //            // Scrivi un programma che chieda all'utente un numero intero.
            //            // Utilizza un ciclo for per stampare la tabellina di quel numero (da 1 a 10)

            int Valore;
            Console.WriteLine("Inserisci un valore: ");
            Valore = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i = i + 1)
            {
                int risultato = Valore * i;
                Console.WriteLine($"{Valore} x {i} = {risultato}");
            }


            // Esercizio (2) Somma dei primi N numeri.
            // Chiedi all'utente un numero N. Calcola la somma di tutti i numeri da 1 a N usando un ciclo for.

            int numero;
            int somma = 0;
            Console.WriteLine("Inserisci un valore: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i = i + 1)
            {
                somma = somma + i;
            }
            Console.WriteLine("--------------");
            Console.WriteLine($"La somma totale è {somma}");

            // Esercizio (3) Elenco invitati
            // Crea un array di stringhe che contiene 5 nomi (es. "Anna", "Luca", "Marco", "Andrea", "Gae")
            // Usa un ciclo foreach per stampare un messaggio di benvenuto per ogni persona nell'array.

            string[] nomi = { "Anna", "Luca", "Marco", "Andrea", "Gae" };

            foreach (string nome in nomi)
            {
                Console.WriteLine($"Benvenuto alla festa, {nome}!");
            }


            // Ecercizio (4) Il conto alla Rovescia
            // Scrivi un programma che simuli il lancio di un razzo.
            // Usa un ciclo for che PARTE DA 10 e ARRIVA A 1.
            // A ogni passaggio,stampa il numero corrente.
            // Dopo il ciclo, stampa la parola "PARTENZA!

            for (int i = 10; i <= 10; i = i - 1)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    Console.WriteLine("PARTENZA! \U0001F680");
                    break;
                }
            }


            // Esercizio (5) Calcolatore di spesa
            // Immagina di avere una lista di prezzi di prodotti nel tuo carrello.
            // Crea un array di type "double" chiamato prezzi con questi valori: {1.50,10.00,4.99,20.50}
            // Crea una variabile "totale" inizializzata a 0.
            // Usa foreach per sommare tutti i prezzi.
            // Stampa alla fine: "Il totale del carrello è: (totale) Euro."

            double[] prezzi = { 1.50, 10.00, 4.99, 20.50 };
            double somma = 0.00;

            foreach (double elementi in prezzi)
            {
                somma = somma + elementi;
            }
            Console.WriteLine($"Il totale del carrello è: {somma}€.");


            // Esercizio (6) Cerca il colore.
            // Crea un elenco di colori e controlla se uno specifico colore è presente.
            // Crea un array di stringhe con i colori: "Rosso, "Blu", "Verde", "Arancione".
            // Usa un ciclo foreach per scorrere l'array.
            // SE il colore corretto è "Arancione", stampa: "Ho trovato l'Arancione! (emoji orange-heart)
            // Altrimenti stampa soltanto il nome del colore.

            string[] emoji = { "Rosso", "Blu", "Verde", "Arancione" };

            foreach (string elemento in emoji)
            {
                if (elemento == "Arancione")
                {
                    Console.WriteLine("Ho trovato l'Arancione! \U0001F9E1");
                }
                else
                {
                    Console.WriteLine(elemento);
                }
            }


            // Esercizio (7) Generatore di quadrati
            // Scrivi un programma che calcoli il quadrato dei primi 5 numeri.
            // Usa un ciclo for che va da 1 a 5.
            // Per ogni numero, calcola il suo quadrato(moltiplicando il numero per se stesso).
            // Stampa il risultato in questo formato: "Il quadrato di 3 è 9".

            for (int i = 1; i <= 5; i = i + 1)
            {
                int quadrato = i * i;
                Console.WriteLine($"Il quadrato di {i} è {quadrato}");
            }
        }
    }
}
