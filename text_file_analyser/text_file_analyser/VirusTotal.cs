
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace text_file_analyser
{
    class VirusTotalScan
    {
        public string APIKey = "82905b25d686e377fdce2c56e462c2c93224e5ff411493ae3efa65913a3d4bf6";
        string scan = "https://www.virustotal.com/vtapi/v2/file/scan";
        string report = "https://www.virustotal.com/vtapi/v2/file/report";
        string putanja = @"../../../text_file_analysis_logic/results/VirusScanResults.txt";

        public VirusTotalScan()
        {
            ServicePointManager.Expect100Continue = false;
        }

        public string Scan(string file)
        {
            var v = new NameValueCollection();
            v.Add("key", APIKey);
            var c = new WebClient() { QueryString = v };
            c.Headers.Add("Content-type", "binary/octet-stream");
            byte[] b = c.UploadFile(scan, "POST", file);
            dynamic objekt = JsonConvert.DeserializeObject(Encoding.Default.GetString(b));
            string id = objekt.scan_id;
            string sha1 = objekt.sha1;
            string kod = objekt.response_code;
            string odgovor = objekt.verbose_msg;          
            if (id!=null || id != "")
            {
                return id;
            }
            else
            {
                return odgovor;
            }       
        }

        public string GetResults(string id)
        {
            var data = string.Format("resource={0}&key={1}", id, APIKey);
            var c = new WebClient();
            string s = c.UploadString(report, "POST", data);
            dynamic rezultat = JsonConvert.DeserializeObject(s);
            if(rezultat==null)
            {
                MessageBox.Show("Pogreška kod dohvaćanja rezultata! Server nije vratio rezultat!");
                return "0";
            }
            int response = rezultat.response_code;
            if(response == -2)
            {
                System.Threading.Thread.Sleep(2000);
                MessageBox.Show("Pogreška kod dohvaćanja rezultata! Rezultati možda još nisu spremni. Pokušajte ponovno za minutu!");
                return response.ToString();
            }
            int total = rezultat.total;
            string positives = rezultat.positives;
            string poruka = rezultat.verbose_msg;
            using (StreamWriter sw = File.CreateText(putanja))
            {
                sw.WriteLine("Testirano na "+total+" antivirusnih programa");
                sw.WriteLine("Virusa pronadeno: "+positives);
                sw.WriteLine("\n\n\n");
                sw.WriteLine("------------------------------");
                sw.WriteLine("      Detaljni pregled        ");
                sw.WriteLine("------------------------------");
                sw.WriteLine(rezultat);
            }
            Process.Start("notepad.exe", putanja);
            return response.ToString();
        }
    }
}
