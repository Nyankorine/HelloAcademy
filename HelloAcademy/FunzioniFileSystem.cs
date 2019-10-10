using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloAcademy
{
    public static class FunzioniFileSystem
    {
        public static void CreaStrutturaPerConservazioniDati() 
        {
            //1) Compongo il percorso deella cartella di lavoro
            var workingFolder = AppDomain.CurrentDomain.BaseDirectory;

            const string DataFolderName = "data";
            const string DataBaseFileName = "database.txt";

            //Compilazione del percorso della folder
            var folderPath = Path.Combine(workingFolder, DataFolderName);

            //Se non eiste, la creo
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            //Composizione del percorso del file database
            string databasePath = Path.Combine(folderPath, DataBaseFileName);

            //Se il file NON esiste, lo creo vuoto
            if (!File.Exists(databasePath))
            {
                //Creazione del file
                using (StreamWriter writer = File.CreateText(databasePath))
                {
                    writer.WriteLine("Questa è una prova di creazione!");
                    writer.Close();
                }
            }
            else
            { 
                using (StreamWriter writer = File.AppendText(databasePath))
                {
                    writer.WriteLine("Questa è una prova di modifica!");
                    writer.Close();
                }
            }

            //Predispongo una lista dei dati di uscita
            List<string> datiDiUscita = new List<string>();

            //Tento la lettura
            using (StreamReader reader = File.OpenText(databasePath)) 
            {
                //Lettura della riga corrente del file
                string readLine = reader.ReadLine();

                datiDiUscita.Add(readLine);
            }

            //Ritorno la lista come array
            string[] arrayDiUscita = new string[datiDiUscita.Count];

            //Itero la lista e aggiungo i valori nell'array
            for (int i = 0; i < datiDiUscita.Count; i++)
            {
                arrayDiUscita[i] = datiDiUscita[i];
            }
        }
    }
}
