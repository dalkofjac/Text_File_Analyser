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
        string putanja = @"../../../text_file_analysis_logic/results/TextAnalysis.txt";
        string rijecNajvisePonavljanje;

        public void pronadiRijeci(string inputFile)
        {
            string[] recenica = File.ReadAllText(inputFile).Split('.');
            string[] linijeTeksta = File.ReadAllLines(inputFile);
            string tekst = File.ReadAllText(inputFile);
            string[] kolekcija = Regex.Matches(tekst, @"\b[\w']*\b")
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();
            kolekcija = kolekcija.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int najveci = 0;
            for (int i=0;i < kolekcija.Count(); i++)
            {
                if (rijecnik.ContainsKey(kolekcija[i])){
                    rijecnik[kolekcija[i]]++;
                }else
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
                sw.WriteLine("Riječ koja se najčešće pojavljuje: " + lista[lista.Count()-1].Key);
                sw.WriteLine("Riječ '" + lista[lista.Count() - 1].Key + "' se pojavljuje: " + lista[lista.Count() - 1].Value);
                sw.WriteLine("\n\n\n");
                sw.WriteLine("------------------------------");
                sw.WriteLine("      Detaljni pregled        ");
                sw.WriteLine("------------------------------");

                for(int i = lista.Count()-1; i >= 0 ; i--)
                {
                    sw.WriteLine(lista[i].Key + ":  " + lista[i].Value);
                }
                sw.WriteLine();
            }
            Process.Start("notepad.exe", putanja);
        }
        public void pronadiRijeci(string inputFile, string max, string min)
        {
            if(min == null || min == "")
            {
                min = "1";
            }
            string regex = "\\b[\\w']{"+min+","+max +"}\\b";
            string[] recenica = File.ReadAllText(inputFile).Split('.');
            string[] linijeTeksta = File.ReadAllLines(inputFile);
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
    }
}
