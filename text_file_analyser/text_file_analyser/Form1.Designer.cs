namespace text_file_analyser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox_format = new System.Windows.Forms.GroupBox();
            this.button_pdf = new System.Windows.Forms.Button();
            this.button_split = new System.Windows.Forms.Button();
            this.label_split = new System.Windows.Forms.Label();
            this.textBox_split = new System.Windows.Forms.TextBox();
            this.groupBox_analyse = new System.Windows.Forms.GroupBox();
            this.button_filescanner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.button_bytestats = new System.Windows.Forms.Button();
            this.button_base64dump = new System.Windows.Forms.Button();
            this.button_rtfdump = new System.Windows.Forms.Button();
            this.textBox_research_word = new System.Windows.Forms.TextBox();
            this.button_research = new System.Windows.Forms.Button();
            this.label_research = new System.Windows.Forms.Label();
            this.button_select_path = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_credentials = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_format.SuspendLayout();
            this.groupBox_analyse.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 6);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label_description);
            this.splitContainer1.Panel1.Controls.Add(this.label_name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_format);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_analyse);
            this.splitContainer1.Panel2.Controls.Add(this.button_select_path);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_path);
            this.splitContainer1.Panel2.Controls.Add(this.label_credentials);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 606);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(541, 106);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(291, 20);
            this.label_description.TabIndex = 7;
            this.label_description.Text = ".txt, .rtf and .doc(x) files analysing tool";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(533, 71);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(253, 36);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Text File Analyser";
            // 
            // groupBox_format
            // 
            this.groupBox_format.Controls.Add(this.button_pdf);
            this.groupBox_format.Controls.Add(this.button_split);
            this.groupBox_format.Controls.Add(this.label_split);
            this.groupBox_format.Controls.Add(this.textBox_split);
            this.groupBox_format.Location = new System.Drawing.Point(838, 88);
            this.groupBox_format.Name = "groupBox_format";
            this.groupBox_format.Size = new System.Drawing.Size(296, 283);
            this.groupBox_format.TabIndex = 21;
            this.groupBox_format.TabStop = false;
            this.groupBox_format.Text = "Formatiranje datoteke";
            // 
            // button_pdf
            // 
            this.button_pdf.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_pdf.Location = new System.Drawing.Point(17, 30);
            this.button_pdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_pdf.Name = "button_pdf";
            this.button_pdf.Size = new System.Drawing.Size(237, 89);
            this.button_pdf.TabIndex = 18;
            this.button_pdf.Text = "Pretvorba datoteke u .pdf (Pdf converter)";
            this.button_pdf.UseVisualStyleBackColor = false;
            this.button_pdf.Click += new System.EventHandler(this.button_pdf_Click);
            // 
            // button_split
            // 
            this.button_split.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_split.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_split.Location = new System.Drawing.Point(17, 124);
            this.button_split.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_split.Name = "button_split";
            this.button_split.Size = new System.Drawing.Size(237, 89);
            this.button_split.TabIndex = 5;
            this.button_split.Text = "Podjela datoteke na više instanci (Split file)";
            this.button_split.UseVisualStyleBackColor = false;
            this.button_split.Click += new System.EventHandler(this.button_split_Click);
            // 
            // label_split
            // 
            this.label_split.AutoSize = true;
            this.label_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_split.Location = new System.Drawing.Point(14, 228);
            this.label_split.Name = "label_split";
            this.label_split.Size = new System.Drawing.Size(160, 18);
            this.label_split.TabIndex = 13;
            this.label_split.Text = "Broj instanci (split): ";
            // 
            // textBox_split
            // 
            this.textBox_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_split.Location = new System.Drawing.Point(200, 225);
            this.textBox_split.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_split.Name = "textBox_split";
            this.textBox_split.Size = new System.Drawing.Size(54, 24);
            this.textBox_split.TabIndex = 14;
            // 
            // groupBox_analyse
            // 
            this.groupBox_analyse.Controls.Add(this.button_filescanner);
            this.groupBox_analyse.Controls.Add(this.button1);
            this.groupBox_analyse.Controls.Add(this.btnAnaliza);
            this.groupBox_analyse.Controls.Add(this.button_bytestats);
            this.groupBox_analyse.Controls.Add(this.button_base64dump);
            this.groupBox_analyse.Controls.Add(this.button_rtfdump);
            this.groupBox_analyse.Controls.Add(this.textBox_research_word);
            this.groupBox_analyse.Controls.Add(this.button_research);
            this.groupBox_analyse.Controls.Add(this.label_research);
            this.groupBox_analyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_analyse.Location = new System.Drawing.Point(77, 88);
            this.groupBox_analyse.Name = "groupBox_analyse";
            this.groupBox_analyse.Size = new System.Drawing.Size(755, 283);
            this.groupBox_analyse.TabIndex = 20;
            this.groupBox_analyse.TabStop = false;
            this.groupBox_analyse.Text = "Analiza datoteke";
            // 
            // button_filescanner
            // 
            this.button_filescanner.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_filescanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filescanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filescanner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_filescanner.Location = new System.Drawing.Point(18, 31);
            this.button_filescanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_filescanner.Name = "button_filescanner";
            this.button_filescanner.Size = new System.Drawing.Size(180, 89);
            this.button_filescanner.TabIndex = 0;
            this.button_filescanner.Text = "Ekstrakcija svih meta-podataka (FileScanner)";
            this.button_filescanner.UseVisualStyleBackColor = false;
            this.button_filescanner.Click += new System.EventHandler(this.button_filescanner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(213, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 89);
            this.button1.TabIndex = 19;
            this.button1.Text = "Analiza teksta u datoteci";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.analizaRijeci);
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnaliza.ForeColor = System.Drawing.Color.White;
            this.btnAnaliza.Location = new System.Drawing.Point(602, 31);
            this.btnAnaliza.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(128, 182);
            this.btnAnaliza.TabIndex = 17;
            this.btnAnaliza.Text = "Analiza virusa u datoteci (VirusTotal servis)";
            this.btnAnaliza.UseVisualStyleBackColor = false;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // button_bytestats
            // 
            this.button_bytestats.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_bytestats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bytestats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bytestats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_bytestats.Location = new System.Drawing.Point(18, 124);
            this.button_bytestats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_bytestats.Name = "button_bytestats";
            this.button_bytestats.Size = new System.Drawing.Size(180, 89);
            this.button_bytestats.TabIndex = 1;
            this.button_bytestats.Text = "Izračun statistike bajtova (Byte-stats)";
            this.button_bytestats.UseVisualStyleBackColor = false;
            this.button_bytestats.Click += new System.EventHandler(this.button_bytestats_Click);
            // 
            // button_base64dump
            // 
            this.button_base64dump.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_base64dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_base64dump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_base64dump.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_base64dump.Location = new System.Drawing.Point(213, 31);
            this.button_base64dump.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_base64dump.Name = "button_base64dump";
            this.button_base64dump.Size = new System.Drawing.Size(180, 89);
            this.button_base64dump.TabIndex = 2;
            this.button_base64dump.Text = "Ekstrakcija base64 stringova (Base64dump)";
            this.button_base64dump.UseVisualStyleBackColor = false;
            this.button_base64dump.Click += new System.EventHandler(this.button_base64dump_Click);
            // 
            // button_rtfdump
            // 
            this.button_rtfdump.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_rtfdump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rtfdump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rtfdump.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_rtfdump.Location = new System.Drawing.Point(408, 31);
            this.button_rtfdump.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rtfdump.Name = "button_rtfdump";
            this.button_rtfdump.Size = new System.Drawing.Size(180, 89);
            this.button_rtfdump.TabIndex = 3;
            this.button_rtfdump.Text = "Ekstrakcija učahurenih stringova (Rtfdump)";
            this.button_rtfdump.UseVisualStyleBackColor = false;
            this.button_rtfdump.Click += new System.EventHandler(this.button_rtfdump_Click);
            // 
            // textBox_research_word
            // 
            this.textBox_research_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_research_word.Location = new System.Drawing.Point(383, 228);
            this.textBox_research_word.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_research_word.Name = "textBox_research_word";
            this.textBox_research_word.Size = new System.Drawing.Size(204, 24);
            this.textBox_research_word.TabIndex = 12;
            // 
            // button_research
            // 
            this.button_research.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_research.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_research.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_research.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_research.Location = new System.Drawing.Point(408, 124);
            this.button_research.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_research.Name = "button_research";
            this.button_research.Size = new System.Drawing.Size(180, 89);
            this.button_research.TabIndex = 4;
            this.button_research.Text = "Pretraga po ključnom izrazu (Re-search)";
            this.button_research.UseVisualStyleBackColor = false;
            this.button_research.Click += new System.EventHandler(this.button_research_Click);
            // 
            // label_research
            // 
            this.label_research.AutoSize = true;
            this.label_research.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_research.Location = new System.Drawing.Point(155, 232);
            this.label_research.Name = "label_research";
            this.label_research.Size = new System.Drawing.Size(205, 18);
            this.label_research.TabIndex = 11;
            this.label_research.Text = "Traženi izraz (re-search): ";
            // 
            // button_select_path
            // 
            this.button_select_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_path.Location = new System.Drawing.Point(77, 38);
            this.button_select_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_select_path.Name = "button_select_path";
            this.button_select_path.Size = new System.Drawing.Size(156, 34);
            this.button_select_path.TabIndex = 16;
            this.button_select_path.Text = "Odabir datoteke";
            this.button_select_path.UseVisualStyleBackColor = true;
            this.button_select_path.Click += new System.EventHandler(this.button_select_path_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_path.Location = new System.Drawing.Point(241, 38);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(893, 35);
            this.textBox_path.TabIndex = 15;
            // 
            // label_credentials
            // 
            this.label_credentials.AutoSize = true;
            this.label_credentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_credentials.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_credentials.Location = new System.Drawing.Point(369, 387);
            this.label_credentials.Name = "label_credentials";
            this.label_credentials.Size = new System.Drawing.Size(429, 13);
            this.label_credentials.TabIndex = 9;
            this.label_credentials.Text = "Made by Dalibor Kofjac and Jurica Bunic @ FOI - 2017 | Powered by Didier Stevens " +
    "Apps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 624);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Analyser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_format.ResumeLayout(false);
            this.groupBox_format.PerformLayout();
            this.groupBox_analyse.ResumeLayout(false);
            this.groupBox_analyse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_select_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_split;
        private System.Windows.Forms.Label label_split;
        private System.Windows.Forms.TextBox textBox_research_word;
        private System.Windows.Forms.Label label_research;
        private System.Windows.Forms.Button button_split;
        private System.Windows.Forms.Label label_credentials;
        private System.Windows.Forms.Button button_research;
        private System.Windows.Forms.Button button_filescanner;
        private System.Windows.Forms.Button button_bytestats;
        private System.Windows.Forms.Button button_rtfdump;
        private System.Windows.Forms.Button button_base64dump;
        private System.Windows.Forms.Button btnAnaliza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_pdf;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_analyse;
        private System.Windows.Forms.GroupBox groupBox_format;
    }
}

