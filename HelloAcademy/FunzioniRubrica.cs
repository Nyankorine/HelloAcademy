using System;
using System.Collections.Generic;
using System.Text;

namespace HelloAcademy
{
    public static class FunzioniRubrica
    {
        public static void InserisciPersoneEMostraRubrica()
        {
            //Dimensiono array per la rubrica
            Person[] rubrica = new Person[3];

            //Richiedo persona 1 (nome + cognome)
            Console.Write("Nome 1: ");
            string nome1 = Console.ReadLine();
            Console.Write("Cognome 1: ");
            string cognome1 = Console.ReadLine();

            //Creo oggetto persona e inserisco valori
            Person uno = new Person();
            uno.FirstName = nome1;
            uno.LastName = cognome1;

            //Aggiungo persona a rubrica
            rubrica[0] = uno;


            //Richiedo persona 2 (nome + cognome)
            Console.Write("Nome 2: ");
            string nome2 = Console.ReadLine();
            Console.Write("Cognome 2: ");
            string cognome2 = Console.ReadLine();

            //Creo oggetto persona e inserisco valori
            Person due = new Person
            {
                FirstName = nome2,
                LastName = cognome2
            };

            //Aggiungo persona a rubrica
            rubrica[1] = due;


            //Richiedo persona 1 (nome + cognome)
            //Creo oggetto persona e inserisco valori
            //Aggiungo persona a rubrica
            Console.Write("Nome 2: ");
            string nome3 = Console.ReadLine();
            Console.Write("Cognome 2: ");
            string cognome3 = Console.ReadLine();
            rubrica[2] = new Person
            {
                FirstName = nome3,
                LastName = cognome3
            };

            //Mostro contenuto rubrica
            // VERSIONE BECERA!!!!
            //Console.WriteLine(rubrica[0].FirstName + ", " + rubrica[0].LastName);
            //Console.WriteLine(rubrica[1].FirstName + ", " + rubrica[1].FirstName);
            //Console.WriteLine(rubrica[2].FirstName + ", " + rubrica[3].FirstName);
            Console.WriteLine("Iterazione rubrica (for):");
            for (int i = 0; i < rubrica.Length; i++)
            {
                Console.WriteLine(rubrica[i].FirstName + ", " + rubrica[i].LastName);
            }

            Console.WriteLine("Iterazione rubrica (while):");
            int index = 0;
            while (index < rubrica.Length)
            {
                Console.WriteLine(rubrica[index].FirstName + ", " + rubrica[index].LastName);
                index = index + 1;
            }

            Console.WriteLine("Iterazione rubrica (foreach):");
            foreach (Person current in rubrica)
            {
                Console.WriteLine(current.FirstName + " " + current.LastName);
            }

        }
        public static void InserisciNumeroArbitrarioPersoneInRubrica()
        {
            //Richiedo il numero di persone da inserire
            Console.Write("Quante persone vuoi aggiungere in rubrica? ");
            string n = Console.ReadLine();
            int nint = int.Parse(n);
            //Validazione del valore immesso e conversione in numero
            //Se il numero è minore o uguale a zero, o maggiore di 10 esco
            if(nint <= 0 || nint > 10)
            {
                Console.Write("Press any key...");
                Console.ReadLine();
                return;
            }
                Person[] rubrica = new Person[nint];
                //Itero per il numero di persone richiesto                             
                for (int i = 0; i < rubrica.Length; i++)
                {
                    int x = i + 1;
                //Richiedo il nome e cognome della persona
                    Console.Write("Nome " + x + " : ");
                    string nome = Console.ReadLine();
                    Console.Write("Cognome " + x + " : ");
                    string cognome = Console.ReadLine();
                    Person person = new Person
                    {
                    FirstName = nome,
                    LastName = cognome
                    };
                //Aggiungo persona a rubrica
                rubrica[i] = person;
                }
            //Se ho inserito tutte le persone termino il ciclo
            //Itero la rubrica e stampo a video (con for) 
            for (int i = 0; i < rubrica.Length; i++)
                Console.WriteLine(rubrica[i].FirstName + " " + rubrica[i].LastName);                    
        }

    }
}
