namespace text_file_analyser
{
    partial class AnalizaRijeciOgranicenje
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 34);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Postavi ograničenja";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(36, 114);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(132, 22);
            this.txtMin.TabIndex = 1;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(253, 114);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(132, 22);
            this.txtMax.TabIndex = 2;
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimalno znakova u riječi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maksimalno znakova u riječi";
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPokreni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPokreni.Location = new System.Drawing.Point(36, 242);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(133, 48);
            this.btnPokreni.TabIndex = 5;
            this.btnPokreni.Text = "Pokreni analizu";
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.Location = new System.Drawing.Point(253, 242);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(133, 48);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // AnalizaRijeciOgranicenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 321);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnalizaRijeciOgranicenje";
            this.Text = "Analiza teksta datoteke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnOdustani;
    }
}