using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_file_analyser
{
    public partial class Form1: Form
    {
        RunPowershellScript rps;
        OpenFileDialog ofd;
        String psScriptPath = @"..\..\..\text_file_analysis_logic\text_file_analysis_script.ps1";
        String selectedPath = "";

        public Form1()
        {
            InitializeComponent();
            rps = new RunPowershellScript();
            ofd = new OpenFileDialog();
        }

        private void button_filescanner_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else {
                rps.RunScript(psScriptPath, "5", "0", selectedPath);
            }

        }

        private void button_bytestats_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else {
                rps.RunScript(psScriptPath, "4", "0", selectedPath);
            }
        }

        private void button_base64dump_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else {
                rps.RunScript(psScriptPath, "3", "0", selectedPath);
            }
        }

        private void button_rtfdump_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else {
                rps.RunScript(psScriptPath, "1", "0", selectedPath);
            }
        }

        private void button_research_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else if (textBox_research_word.Text.Length == 0)
            {
                MessageBox.Show("Molimo unesite izraz za pretragu!", "Upozorenje");
                textBox_research_word.Focus();
            }
            else {
                String searchString = textBox_research_word.Text;
                rps.RunScript(psScriptPath, "6", searchString, selectedPath);
            }
        }

        private void button_split_Click(object sender, EventArgs e)
        {
            if (fileTypeCheck() == false)
            {
                MessageBox.Show("Nije odabrana datoteka ili je pogrešan tip!", "Upozorenje");
            }
            else if (textBox_split.Text.Length == 0)
            {
                MessageBox.Show("Molimo unesite željeni broj kopija!", "Upozorenje");
                textBox_split.Focus();
            }
            else {
                try
                {
                    int splitParts = int.Parse(textBox_split.Text);
                    if (splitParts <= 100 && splitParts > 0)
                    {
                        rps.RunScript(psScriptPath, "2", splitParts.ToString(), selectedPath);
                    }
                    else
                    {
                        MessageBox.Show("Krivi unos broja kopija! (1-100)", "Upozorenje");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Krivi unos broja kopija!", "Upozorenje");
                }
            }
        }

        private void button_select_path_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                selectedPath = ofd.InitialDirectory + ofd.FileName;
            }
            textBox_path.Text = selectedPath;

        }
        
        private bool fileTypeCheck() {
            if (selectedPath.Length == 0) {
                return false;
            }
            string selectedFileName = ofd.FileName;
            int sfLengh = selectedFileName.Length;
            string sfType1 = "";
            string sfType2 = "";
            string sfTypeRtf = ".rtf";
            string sfTypeTxt = ".txt";
            string sfTypeDoc = ".doc";
            string sfTypeDocx = ".docx";
            sfType1 = selectedFileName.Substring(selectedFileName.Length - 4);
            sfType2 = selectedFileName.Substring(selectedFileName.Length - 5);
            if (sfType1.Equals(sfTypeRtf) == true || sfType1.Equals(sfTypeTxt) == true || sfType1.Equals(sfTypeDoc) == true)
            {
                return true;
            }
            else if(sfType2.Equals(sfTypeDocx) == true){
                return true;
            }
            return false;
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            VirusTotalScan ca = new VirusTotalScan();
            String id = ca.Scan(selectedPath);
            String rezultat = ca.GetResults(id);
        }
    }
}
