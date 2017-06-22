using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace text_file_analyser
{
    class AnalizaRijeci
    {
        Dictionary<string, int> rijecnik = new Dictionary<string, int>();
        Dictionary<string, int> emailovi = new Dictionary<string, int>();
        string putanja = @"../../../text_file_analysis_logic/results/TextAnalysis.txt";

        string rijecNajvisePonavljanje;
        string mailNajvisePonavljanje;

        public void pronadiRijeci(string inputFile, string max, string min)
        {
            if(min == null || min == "")
            {
                min = "1";
            }
            string regex = "\\b[\\w']{"+min+","+max +"}\\b";
            string tekst = File.ReadAllText(inputFile);
            string[] kolekcija = Regex.Matches(tekst, regex)
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();
            kolekcija = kolekcija.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int najveci = 0;
            
            for (int i = 0; i < kolekcija.Count(); i++)
            {
                if (rijecnik.ContainsKey(kolekcija[i]))
                {
                    rijecnik[kolekcija[i]]++;
                }
                else
                {
                    rijecnik.Add(kolekcija[i], 1);
                }
                if (rijecnik[kolekcija[i]] > 0)
                {
                    rijecNajvisePonavljanje = kolekcija[i];
                }
            }
            using (StreamWriter sw = File.CreateText(putanja))
            {
                var lista = rijecnik.ToList();
                lista.Sort((kljuc, vrijednost) => kljuc.Value.CompareTo(vrijednost.Value));
                sw.WriteLine("Broj različitih riječi: " + lista.Count());
                sw.WriteLine("Riječ koja se najčešće pojavljuje: " + lista[lista.Count() - 1].Key);
                sw.WriteLine("Riječ '" + lista[lista.Count() - 1].Key + "' se pojavljuje: " + lista[lista.Count() - 1].Value);
                sw.WriteLine("\n\n\n");
                sw.WriteLine("------------------------------");
                sw.WriteLine("      Detaljni pregled        ");
                sw.WriteLine("------------------------------");

                for (int i = lista.Count() - 1; i >= 0; i--)
                {
                    sw.WriteLine(lista[i].Key + ":  " + lista[i].Value);
                }
                sw.WriteLine();
            }
            Process.Start("notepad.exe", putanja);
        }
        public void pronadiRijeciMail(string inputFile, string max, string min, bool email)
        {
            if (min == null || min == "")
            {
                min = "1";
            }
            string regex = "\\b[\\w']{" + min + "," + max + "}\\b";
            string tekst = File.ReadAllText(inputFile);
            string[] kolekcija = Regex.Matches(tekst, regex)
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();
            kolekcija = kolekcija.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            regex = @"(?=.{8})[a-z0-9%+_-]+(?:\.[a-z0-9%+_-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z]{2,4}";
            string[] mail = Regex.Matches(tekst, regex)
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();

            for (int i = 0; i < kolekcija.Count(); i++)
            {
                if (rijecnik.ContainsKey(kolekcija[i]))
                {
                    rijecnik[kolekcija[i]]++;
                }
                else
                {
                    rijecnik.Add(kolekcija[i], 1);
                }
            }
            for(int i = 0; i< mail.Count(); i++)
            {
                if (emailovi.ContainsKey(mail[i]))
                {
                    emailovi[mail[i]]++;
                }
                else
                {
                    emailovi.Add(mail[i], 1);
                }
            }
            using (StreamWriter sw = File.CreateText(putanja))
            {
                var lista = rijecnik.ToList();
                var listaMail = emailovi.ToList();
                lista.Sort((kljuc, vrijednost) => kljuc.Value.CompareTo(vrijednost.Value));
                listaMail.Sort((kljuc, vrijednost) => kljuc.Value.CompareTo(vrijednost.Value));
                sw.WriteLine("Broj različitih riječi: " + lista.Count());
                sw.WriteLine("Riječ koja se najčešće pojavljuje: " + lista[lista.Count() - 1].Key);
                sw.WriteLine("Riječ '" + lista[lista.Count() - 1].Key + "' se pojavljuje: " + lista[lista.Count() - 1].Value);
                try
                {
                    sw.WriteLine("Najčešće spominjan e-mail: " + listaMail[listaMail.Count() - 1].Key + " broj ponavljanje:" + listaMail[listaMail.Count() - 1].Value);
                }
                catch
                {

                }
                sw.WriteLine("\n\n\n");
                sw.WriteLine("------------------------------");
                sw.WriteLine("      Detaljni pregled        ");
                sw.WriteLine("------------------------------");
                sw.WriteLine("-----Mailovi");
                try
                {
                    for (int i = listaMail.Count() - 1; i >= 0; i--)
                    {
                        sw.WriteLine(listaMail[i].Key + ": " + listaMail[i].Value);
                    }
                }
                catch
                {

                }
                
                sw.WriteLine("-----");
                for (int i = lista.Count() - 1; i >= 0; i--)
                {
                    sw.WriteLine(lista[i].Key + ":  " + lista[i].Value);
                }

                sw.WriteLine();
            }
            Process.Start("notepad.exe", putanja);
        }
    }
}
