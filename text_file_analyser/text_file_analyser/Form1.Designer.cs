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
            this.button1 = new System.Windows.Forms.Button();
            this.button_pdf = new System.Windows.Forms.Button();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.button_select_path = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_split = new System.Windows.Forms.TextBox();
            this.label_split = new System.Windows.Forms.Label();
            this.textBox_research_word = new System.Windows.Forms.TextBox();
            this.label_research = new System.Windows.Forms.Label();
            this.button_split = new System.Windows.Forms.Button();
            this.label_credentials = new System.Windows.Forms.Label();
            this.button_research = new System.Windows.Forms.Button();
            this.button_filescanner = new System.Windows.Forms.Button();
            this.button_bytestats = new System.Windows.Forms.Button();
            this.button_rtfdump = new System.Windows.Forms.Button();
            this.button_base64dump = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(9, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button_pdf);
            this.splitContainer1.Panel2.Controls.Add(this.btnAnaliza);
            this.splitContainer1.Panel2.Controls.Add(this.button_select_path);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_path);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_split);
            this.splitContainer1.Panel2.Controls.Add(this.label_split);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_research_word);
            this.splitContainer1.Panel2.Controls.Add(this.label_research);
            this.splitContainer1.Panel2.Controls.Add(this.button_split);
            this.splitContainer1.Panel2.Controls.Add(this.label_credentials);
            this.splitContainer1.Panel2.Controls.Add(this.button_research);
            this.splitContainer1.Panel2.Controls.Add(this.button_filescanner);
            this.splitContainer1.Panel2.Controls.Add(this.button_bytestats);
            this.splitContainer1.Panel2.Controls.Add(this.button_rtfdump);
            this.splitContainer1.Panel2.Controls.Add(this.button_base64dump);
            this.splitContainer1.Size = new System.Drawing.Size(826, 519);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(406, 86);
            this.label_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(246, 17);
            this.label_description.TabIndex = 7;
            this.label_description.Text = ".txt, .rtf and .doc(x) files analysing tool";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(400, 58);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(205, 29);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Text File Analyser";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(197, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 83);
            this.button1.TabIndex = 19;
            this.button1.Text = "Analiza teksta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.analizaRijeci);
            // 
            // button_pdf
            // 
            this.button_pdf.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_pdf.Location = new System.Drawing.Point(58, 171);
            this.button_pdf.Margin = new System.Windows.Forms.Padding(2);
            this.button_pdf.Name = "button_pdf";
            this.button_pdf.Size = new System.Drawing.Size(135, 83);
            this.button_pdf.TabIndex = 18;
            this.button_pdf.Text = "Pretvorba datoteke u .pdf (Pdf converter)";
            this.button_pdf.UseVisualStyleBackColor = false;
            this.button_pdf.Click += new System.EventHandler(this.button_pdf_Click);
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnaliza.ForeColor = System.Drawing.Color.White;
            this.btnAnaliza.Location = new System.Drawing.Point(616, 84);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(115, 169);
            this.btnAnaliza.TabIndex = 17;
            this.btnAnaliza.Text = "Analiza datoteke preko Virus Total servisa";
            this.btnAnaliza.UseVisualStyleBackColor = false;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // button_select_path
            // 
            this.button_select_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_path.Location = new System.Drawing.Point(58, 39);
            this.button_select_path.Margin = new System.Windows.Forms.Padding(2);
            this.button_select_path.Name = "button_select_path";
            this.button_select_path.Size = new System.Drawing.Size(117, 28);
            this.button_select_path.TabIndex = 16;
            this.button_select_path.Text = "Odabir datoteke";
            this.button_select_path.UseVisualStyleBackColor = true;
            this.button_select_path.Click += new System.EventHandler(this.button_select_path_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_path.Location = new System.Drawing.Point(181, 39);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(552, 29);
            this.textBox_path.TabIndex = 15;
            // 
            // textBox_split
            // 
            this.textBox_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_split.Location = new System.Drawing.Point(452, 291);
            this.textBox_split.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_split.Name = "textBox_split";
            this.textBox_split.Size = new System.Drawing.Size(154, 21);
            this.textBox_split.TabIndex = 14;
            // 
            // label_split
            // 
            this.label_split.AutoSize = true;
            this.label_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_split.Location = new System.Drawing.Point(262, 291);
            this.label_split.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_split.Name = "label_split";
            this.label_split.Size = new System.Drawing.Size(195, 15);
            this.label_split.TabIndex = 13;
            this.label_split.Text = "Broj instanci datoteke (split): ";
            // 
            // textBox_research_word
            // 
            this.textBox_research_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_research_word.Location = new System.Drawing.Point(452, 266);
            this.textBox_research_word.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_research_word.Name = "textBox_research_word";
            this.textBox_research_word.Size = new System.Drawing.Size(154, 21);
            this.textBox_research_word.TabIndex = 12;
            // 
            // label_research
            // 
            this.label_research.AutoSize = true;
            this.label_research.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_research.Location = new System.Drawing.Point(281, 269);
            this.label_research.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_research.Name = "label_research";
            this.label_research.Size = new System.Drawing.Size(173, 15);
            this.label_research.TabIndex = 11;
            this.label_research.Text = "Traženi izraz (re-search): ";
            // 
            // button_split
            // 
            this.button_split.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_split.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_split.Location = new System.Drawing.Point(476, 171);
            this.button_split.Margin = new System.Windows.Forms.Padding(2);
            this.button_split.Name = "button_split";
            this.button_split.Size = new System.Drawing.Size(135, 83);
            this.button_split.TabIndex = 5;
            this.button_split.Text = "Podjela datoteke na više instanci (Split file)";
            this.button_split.UseVisualStyleBackColor = false;
            this.button_split.Click += new System.EventHandler(this.button_split_Click);
            // 
            // label_credentials
            // 
            this.label_credentials.AutoSize = true;
            this.label_credentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_credentials.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_credentials.Location = new System.Drawing.Point(281, 332);
            this.label_credentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_credentials.Name = "label_credentials";
            this.label_credentials.Size = new System.Drawing.Size(367, 12);
            this.label_credentials.TabIndex = 9;
            this.label_credentials.Text = "Made by Dalibor Kofjac and Jurica Bunic @ FOI - 2017 | Powered by Didier Stevens " +
    "Apps";
            // 
            // button_research
            // 
            this.button_research.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_research.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_research.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_research.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_research.Location = new System.Drawing.Point(337, 171);
            this.button_research.Margin = new System.Windows.Forms.Padding(2);
            this.button_research.Name = "button_research";
            this.button_research.Size = new System.Drawing.Size(135, 83);
            this.button_research.TabIndex = 4;
            this.button_research.Text = "Pretraga po ključnom izrazu (Re-search)";
            this.button_research.UseVisualStyleBackColor = false;
            this.button_research.Click += new System.EventHandler(this.button_research_Click);
            // 
            // button_filescanner
            // 
            this.button_filescanner.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_filescanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filescanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filescanner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_filescanner.Location = new System.Drawing.Point(58, 84);
            this.button_filescanner.Margin = new System.Windows.Forms.Padding(2);
            this.button_filescanner.Name = "button_filescanner";
            this.button_filescanner.Size = new System.Drawing.Size(135, 83);
            this.button_filescanner.TabIndex = 0;
            this.button_filescanner.Text = "Ekstrakcija svih meta-podataka (FileScanner)";
            this.button_filescanner.UseVisualStyleBackColor = false;
            this.button_filescanner.Click += new System.EventHandler(this.button_filescanner_Click);
            // 
            // button_bytestats
            // 
            this.button_bytestats.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_bytestats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bytestats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bytestats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_bytestats.Location = new System.Drawing.Point(197, 84);
            this.button_bytestats.Margin = new System.Windows.Forms.Padding(2);
            this.button_bytestats.Name = "button_bytestats";
            this.button_bytestats.Size = new System.Drawing.Size(135, 83);
            this.button_bytestats.TabIndex = 1;
            this.button_bytestats.Text = "Izračun statistike bajtova (Byte-stats)";
            this.button_bytestats.UseVisualStyleBackColor = false;
            this.button_bytestats.Click += new System.EventHandler(this.button_bytestats_Click);
            // 
            // button_rtfdump
            // 
            this.button_rtfdump.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_rtfdump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rtfdump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rtfdump.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_rtfdump.Location = new System.Drawing.Point(476, 84);
            this.button_rtfdump.Margin = new System.Windows.Forms.Padding(2);
            this.button_rtfdump.Name = "button_rtfdump";
            this.button_rtfdump.Size = new System.Drawing.Size(135, 83);
            this.button_rtfdump.TabIndex = 3;
            this.button_rtfdump.Text = "Ekstrakcija učahurenih stringova (Rtfdump)";
            this.button_rtfdump.UseVisualStyleBackColor = false;
            this.button_rtfdump.Click += new System.EventHandler(this.button_rtfdump_Click);
            // 
            // button_base64dump
            // 
            this.button_base64dump.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_base64dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_base64dump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_base64dump.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_base64dump.Location = new System.Drawing.Point(337, 84);
            this.button_base64dump.Margin = new System.Windows.Forms.Padding(2);
            this.button_base64dump.Name = "button_base64dump";
            this.button_base64dump.Size = new System.Drawing.Size(135, 83);
            this.button_base64dump.TabIndex = 2;
            this.button_base64dump.Text = "Ekstrakcija base64 stringova (Base64dump)";
            this.button_base64dump.UseVisualStyleBackColor = false;
            this.button_base64dump.Click += new System.EventHandler(this.button_base64dump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 533);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

