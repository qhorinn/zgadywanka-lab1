﻿namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(101, 38);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresOd);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 72);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(348, 157);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(97, 42);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 26);
            this.textBoxZakresOd.TabIndex = 0;
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(7, 42);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(84, 20);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(7, 107);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(84, 20);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(97, 104);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 26);
            this.textBoxZakresDo.TabIndex = 3;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(235, 67);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(84, 36);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Losuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 509);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresOd;
    }
}

