using System;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorsoCSharp
{
    class Eserciziwhile
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Esercizi con While, DoWhile e If annidati.
            // 1.Chiedi all'utente di inserire un numero positivo. Se l'utente inserisce un numero minore o uguale
            // a zero, mostra un errore e richiedi l'inserimento finché il dato non è corretto.


             //Console.ReadLine() vuole che la risposta sia SOLO in formato(string).
             // Adesso trasformiamo la variabile in (int).
             int RispostaUtente;

            do
            {
                Console.WriteLine("Inserisci un valore positivo: ");
                RispostaUtente = int.Parse(Console.ReadLine());

                if (RispostaUtente > 0)
                {
                    Console.WriteLine("Esatto. Il valore è maggiore di 0");
                }
                else
                {
                    Console.WriteLine("Non è il valore che voglio. Inserire un valore positivo: ");
                    RispostaUtente = int.Parse(Console.ReadLine());
                }

            } while (RispostaUtente <= 0);
            Console.WriteLine("Ottimo, era il valore che volevo!");




            //Esercizio 2: Scrivi un programma che simuli un piccolo distributore.
            // 1.Chiedi all'utente di scegliere tra "Caffè" o "Tè".
            // 2.Se sceglier "Caffè", chiedi se lo vuoi "Lungo o corto".
            // 3.Se sceglie "Tè", chiedi se lo vuole "Verde" o "Nero".
            // 4.Se l'utente inserisce una scelta non valida in qualsiasi passaggio, stampa un messaggio di errore.
            // 5.Alla fine, stampa il riepilogo della scelta(es. "Ecco il tuo Tè Verde)


            string Bevanda;
            Console.WriteLine("Benvenuto. Quale bevanda desidera?");
            Bevanda = Console.ReadLine();

            if (Bevanda == "Caffè")
            {
                string RispostaC;
                Console.WriteLine("Lungo o ristretto?");
                RispostaC = Console.ReadLine();
                if (RispostaC == "Lungo")
                {
                    Console.WriteLine("Ecco il tuo " + Bevanda + " " + RispostaC);
                }
                else
                {
                    Console.WriteLine("Ecco il tuo " + Bevanda + " ristretto.");
                }
            }
            else if (Bevanda == "Tè")
            {
                string RispostaT;
                Console.WriteLine("Nero o verde?");
                RispostaT = Console.ReadLine();
                if (RispostaT == "Nero")
                {
                    Console.WriteLine("Perfetto! Ecco il tuo " + Bevanda + " " + RispostaT);
                }
                else
                {
                    Console.WriteLine("Ecco il tuo " + Bevanda + " Verde!");
                }
            }
            else
            {
                Console.WriteLine("Non abbiamo questa bevanda");
            }


            // Esercizio 3.Crea un gioco in cui il computer "pensa" un numero(puoi fissarlo tu, ad esempio 42).
            // 1.Il programma deve continuare a chiedere all'utente di indovinare il numero finché non inserisce
            // quello corretto.
            // 2.Per ogni tentativo sbagliato, il programma deve dire se il numero inserito è "Troppo alto"
            // o "Troppo basso".
            // 3.Quando l'utente indovina, stampa un messaggio di congratulazioni e il numero totale di tentativi effettuati.

            int i = 1;  // <-contatore(n.tentativi)
            int valore = 42;

            Console.WriteLine("Che numero penso?");
            int RispostaUtente1 = int.Parse(Console.ReadLine());

            while (RispostaUtente1 != valore)
            {
                if (RispostaUtente1 > valore)
                {
                    Console.WriteLine("Hai sbagliato il valore. Troppo alto. Riprova:");
                }
                else
                {
                    Console.WriteLine("Hai sbagliato il valore. Troppo basso. Riprova.");
                }
                RispostaUtente1 = int.Parse(Console.ReadLine());
                i = i + 1;
            }
            Console.WriteLine("Congratulazioni! Hai indovinato il numero e hai utilizzato ben " + i + " tentativi.");



            //Esercizio 4: Scrivi un programma che richiede all'utente di inserire un voto scolastico compreso tra 1 e 10.
            // Usa un ciclo "dowhile" per forzare l'utente a inserire un numero valido. 
            // Se il numero è fuori dall'intervallo, il programma deve mostrare un errore e richiedere l'inserimento.

            // Una volta ottenuto un voto valido, usa IF(o SWITCH) per stampare:
            // -"Insufficiente" se il voto è minore di 6.
            // - "Sufficiente" se è tra 6 e 8.
            // - "Ottimo" se è 9 o 10


            int Risposta;

            do
            {
                Console.WriteLine("Inserisci un voto da 1 a 10");
                Risposta = int.Parse(Console.ReadLine());
                if ((Risposta < 1) || (Risposta > 10))
                {
                    Console.WriteLine("Errore. Valore fuori intervallo. Riprova");
                }
            } while ((Risposta < 1) || (Risposta > 10));

            if (Risposta < 6)
            {
                Console.WriteLine("Insufficiente");
            }
            else if ((Risposta >= 6) && (Risposta <= 8))
            {
                Console.WriteLine("Sufficiente");
            }
            else
            {
                Console.WriteLine("Ottimo");
            }


            //Esercizio5.Password
            //Creare un sistema che chieda una password finchè non è corretta.
            // Scrivi un programma che chieda all'utente di inserire una password (stringa).
            // Se la passowrd inserita è "Gemin1_2026", stampa "Accesso consentito!.
            // Se la password è sbagliata, stampa "Password errata, riprova" e chiedila di nuovo.
            // Vincolo: Usa un ciclo do -while perchè la richiesta deve avvenire almeno una volta.



            string Password = "Gemin1_2026";
            string Risposta1;
            do
            {
                Console.WriteLine("Inserisci la password:");
                Risposta1 = Console.ReadLine();

                if (Risposta1 != "Gemin1_2026")
                {
                    Console.WriteLine("Password errata.Riprova:");
                }
            } while (Risposta1 != "Gemin1_2026");

            if (Risposta1 == "Gemin1_2026")
            {
                Console.WriteLine("Accesso consentito");
            }


            //Esercizio 6.Numeri Pari e Dispari,
            // Crea un programma che chieda all'utente un numero intero positivo N.
            // Usando un ciclo(while), stampa tutti i numero da 1 a N.
            // Per ogni numero, usa un "if-else" al numero se è "Pari" o "Dispari".

            Console.WriteLine("Inserisci un valore positivo: ");

            int numero;
            numero = int.Parse(Console.ReadLine());
            int y = 1;  // <- contatore


            while (y <= numero)
            {
                if ((y >= 1) && (y % 2 == 0))
                {
                    Console.WriteLine(y + " = Pari");
                }
                else
                {
                    Console.WriteLine(y + " = Dispari");
                }
                y = y + 1;

            }
            Console.WriteLine("Ciclo terminato");


            //Esercizio 7 Somma Sentinella
            // Scrivi un programma che chieda all'utente di inserie dei numeri interi, uno alla volta.
            // Il programma deve continuare a chiedere numeri finchè l'utente non inserisce lo 0 (sentinella per uscire).
            // All'interno del ciclo:
            // (1) Se il numero inserito è maggiore di 100, stampa "numero molto grande".
            // (2) Se il numero è minore di 0, stampa "Numero negativo saltato" e NON aggiungerlo alla somma.
            // (3) Altrimenti, aggiungi il numero a una variabile somma

            // Alla fine del ciclo(quando l'utente digita 0), stampa la somma totale ottenuta.

            int numero1;
            int somma = 0; // contatore che andrà a sommare tutti i valori che l'untente inserirà in input. 

            Console.WriteLine("Inserisci un valore:");
            numero1 = int.Parse(Console.ReadLine());

            while (numero1 != 0)
            {
                if (numero1 > 100)
                {
                    Console.WriteLine("Numero molto grande");
                    somma = somma + numero1;
                }
                else if (numero1 < 0)
                {
                    Console.WriteLine("Numero negativo saltato. Non verrà inserito alla somma.");
                }
                else
                {
                    somma = somma + numero1;
                }
                Console.WriteLine("Inserisci un altro numero (0 per terminare): ");
                numero1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La somma è pari a " + somma);



            //Esercizio 8 Bancomat Semplificato.
            // Immagina di avere un saldo iniziale di 500€. Crea un menù che mostri 3 opzioni: 1.Preleva, 2.Deposita, 3.Esci
            // Utilizza un ciclo "do-while" per mostrare il menù finchè l'utente non sceglie l'opzione 3.

            // Logica interna.
            // Se sceglie(1): Chiedi quanto vuole prelevare. Se la cifra è disponibile, sottraila dal saldo, altrimenti stampa "Fondi insufficienti".
            // Se sceglie(2): Chiedi quanto vuole depositare e aggiungilo al saldo.
            // Se sceglie(3): Saluti l'utente e chiudi il programma.
            // Se sceglie un altro numero stampa "Opzione non valida".

            int saldo = 500;
            int InputCliente;

            do
            {
                Console.WriteLine("Benvenuto. Seleziona una delle tre opzioni disponibili: 1.Prelveva, 2.Deposita, 3.Esci");
                InputCliente = int.Parse(Console.ReadLine());

                if (InputCliente == 1)
                {
                    Console.WriteLine("Quanto vuole prelevare?");
                    int cifra1 = int.Parse(Console.ReadLine());

                    if (cifra1 <= 500)
                    {
                        int SaldoTot = saldo - cifra1;
                        Console.WriteLine("Hai prelevato " + cifra1 + " e adesso hai " + SaldoTot + " sul saldo totale");
                    }
                    else
                    {
                        Console.WriteLine("Saldo non disponibile.");
                    }
                }
                else if (InputCliente == 2)
                {
                    Console.WriteLine("Quanto vuole depositare?");
                    int cifra2 = int.Parse(Console.ReadLine());
                    int SaldoTot = cifra2 + saldo;
                    Console.WriteLine("Hai depositato " + cifra2 + " e adesso hai " + SaldoTot + " sul saldo totale");
                }
                else
                {
                    Console.WriteLine("Perfetto, arrivederci!");
                }

            } while (InputCliente != 3);


            //Esercizio 9: Salvadanaio
            //Vuoi comprare un gioco che costa 50€. Crea un programma che chieda all'utente quanto vuole inserire nel salvadanaio.
            // Il ciclo while deve continuare finchè la "sommaTotale" è inferiore a 50.

            // Logica interna:
            // Se l'utente inserisce una cifra negativa o zero, stampa "Non puoi rubare dal salvadanaio!" e non aggiungere nulla.
            // Se inserisce una cifra positiva, aggiungia al totale e stampa: "Saldo attuale: X €"
            // Quando il ciclo finisce, stampa "Obiettivo raggiunto! puoi comprare il gioco.


            int sommaTotale = 0;
            int numero2;

            while (sommaTotale < 50)
            {
                Console.WriteLine("Quanto aggiungi al salvadanaio?");
                numero2 = int.Parse(Console.ReadLine());
                if (numero2 <= 0)
                {
                    Console.WriteLine("Non puoi rubare dal salvadanaio!");
                }
                else
                {
                    sommaTotale = sommaTotale + numero2;
                    Console.WriteLine($"Saldo attuale: {sommaTotale:C}"); // <- {NomeVariabile : C} permette al sistema di riconoscere le impostazioni regionali del mio PC.
                                                                          // In questo caso, inserirà il simbolo €. 
                }
            }
            Console.WriteLine("Obiettivo raggiunto! Puoi comprare il gioco.");
            Console.Read();


            //Esercizio10.Login
            //Creare un sistema che chieda una password e una email finchè non è corretta.
            // Scrivi un programma che chieda all'utente di inserire una password (stringa) e un username (stringa).
            // Se la passowrd inserita è "Lasetta126" e username "Sora126@gmail.com, stampa "Accesso consentito!.
            // Se la password o username è sbagliata, stampa "Password/username errata, riprova" e chiedila di nuovo.
            // Vincolo: Usa un ciclo do -while perchè la richiesta deve avvenire almeno una volta.

            string username = "Sora126@gmail.com";
            string password = "Lasetta126";
            string RispostaUser;
            string RispostaPass;
            do
            {
                Console.WriteLine("Inserisci username e password:");
                RispostaUser = Console.ReadLine();
                RispostaPass = Console.ReadLine();

                if ((RispostaUser != username) || (RispostaPass != password))
                {
                    Console.WriteLine("Impossibile accedere. Username / Password non corretta.Riprova:");
                }

            } while ((RispostaUser != "Sora126@gmail.com") || (RispostaPass != "Lasetta126"));

            if ((RispostaUser == username) && (RispostaPass == password))
            {
                Console.WriteLine("ACCESSO CONSENTITO");
            }




            //Esercizio 11.Controllo Temperatura
            //Immagina di controllare un reattore. La temperatura deve essere compresa tra 20°C e 40°C.
            //Usa "do-while" per chiedere la temperatura all'utente.

            // Logica interna
            // Se la temperatura è maggiore di 40, stampa "PERICOLO: Temperatura troppo alta! Raffreddamento in corso...".
            // Se la temperatura è minore di 20, stampa "AVVISO: Temperatura troppo bassa! Riscaldamento in corso..."
            // Se la temperatura è corretta(tra 20 e 40), stampa "Sistema stabile".

            // Paletto.Il ciclo deve fermarsi solo quando la temperatura inserita è finalmente corretta.

            int Risposta3;

            do
            {
                Console.WriteLine("Inserisci la temperatura attuale del reattore (20-40°C): ");
                Risposta3 = int.Parse(Console.ReadLine());

                if (Risposta3 > 40)
                {
                    Console.WriteLine("PERICOLO: Temperatura troppo alta! Raffreddamento in corso...");
                }
                else if (Risposta3 < 20)
                {
                    Console.WriteLine("AVVISO: Temperatura troppo bassa! Riscaldamento in corso...");
                }

            } while ((Risposta3 <= 20) || (Risposta3 >= 40));

            if ((Risposta3 >= 20) && (Risposta3 <= 40))
            {
                Console.WriteLine("Sistema stabile. Temperatura ottimale");
            }
            Console.WriteLine("Procedura completata. Il reattore è operativo");
        }
    }
}
