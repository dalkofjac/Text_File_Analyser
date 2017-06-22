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
    public partial class AnalizaRijeciOgranicenje : Form
    {
        string putanja;

        public AnalizaRijeciOgranicenje(string putanja)
        {
            this.putanja = putanja;
            InitializeComponent();
            if (!checkBox1.Checked)
            {
                txtMin.Text = "";
                txtMin.ReadOnly = true;
                txtMax.Text = "";
                txtMax.ReadOnly = true;
            }
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtMin.Text = "";
                txtMin.ReadOnly = true;
                txtMax.Text = "";
                txtMax.ReadOnly = true;
            }
            else
            {
                txtMin.ReadOnly = false;
                txtMax.ReadOnly = false;
            }
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            AnalizaRijeci ar = new AnalizaRijeci();
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    ar.pronadiRijeciMail(putanja, txtMax.Text, txtMin.Text, true);
                }
                else
                {
                    ar.pronadiRijeci(putanja, txtMax.Text, txtMin.Text);
                }

            }
            else
            {
                if (checkBox2.Checked)
                {
                    ar.pronadiRijeciMail(putanja, txtMax.Text, txtMin.Text, true);
                }else
                {
                    ar.pronadiRijeci(putanja, txtMax.Text, txtMin.Text);
                }
                
            }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
