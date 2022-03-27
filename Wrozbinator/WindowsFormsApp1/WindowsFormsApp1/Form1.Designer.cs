namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPodaj = new System.Windows.Forms.Button();
            this.dzien = new System.Windows.Forms.TextBox();
            this.miesiac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.poleZodiak = new System.Windows.Forms.Label();
            this.poleLiczba = new System.Windows.Forms.Label();
            this.polePOL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPodaj
            // 
            this.btnPodaj.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPodaj.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodaj.Location = new System.Drawing.Point(348, 240);
            this.btnPodaj.Name = "btnPodaj";
            this.btnPodaj.Size = new System.Drawing.Size(234, 44);
            this.btnPodaj.TabIndex = 0;
            this.btnPodaj.Text = "ZWRÓŻBINATUJ";
            this.btnPodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPodaj.UseVisualStyleBackColor = false;
            this.btnPodaj.Click += new System.EventHandler(this.btnPodaj_Click);
            // 
            // dzien
            // 
            this.dzien.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dzien.Location = new System.Drawing.Point(81, 131);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(100, 20);
            this.dzien.TabIndex = 1;
            this.dzien.TextChanged += new System.EventHandler(this.dzien_TextChanged);
            // 
            // miesiac
            // 
            this.miesiac.BackColor = System.Drawing.Color.LightSkyBlue;
            this.miesiac.Location = new System.Drawing.Point(729, 131);
            this.miesiac.Name = "miesiac";
            this.miesiac.Size = new System.Drawing.Size(100, 20);
            this.miesiac.TabIndex = 2;
            this.miesiac.TextChanged += new System.EventHandler(this.miesiac_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PODAJ DZIEŃ URODZENIA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.label2.Location = new System.Drawing.Point(626, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PODAJ MIESIĄC URODZENIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(335, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "TWÓJ ZNAK ZODIAKU TO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "TWOJA SZCZĘŚLIWA LICZBA TO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(690, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "TWOJE LATA ŻYCIA TO:";
            // 
            // poleZodiak
            // 
            this.poleZodiak.AutoSize = true;
            this.poleZodiak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.poleZodiak.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleZodiak.Location = new System.Drawing.Point(396, 417);
            this.poleZodiak.Name = "poleZodiak";
            this.poleZodiak.Size = new System.Drawing.Size(0, 45);
            this.poleZodiak.TabIndex = 8;
            this.poleZodiak.Click += new System.EventHandler(this.poleZodiak_Click);
            // 
            // poleLiczba
            // 
            this.poleLiczba.AutoSize = true;
            this.poleLiczba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.poleLiczba.Font = new System.Drawing.Font("Impact", 18F);
            this.poleLiczba.Location = new System.Drawing.Point(126, 368);
            this.poleLiczba.Name = "poleLiczba";
            this.poleLiczba.Size = new System.Drawing.Size(0, 29);
            this.poleLiczba.TabIndex = 9;
            this.poleLiczba.Click += new System.EventHandler(this.poleLiczba_Click);
            // 
            // polePOL
            // 
            this.polePOL.AutoSize = true;
            this.polePOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.polePOL.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polePOL.Location = new System.Drawing.Point(772, 368);
            this.polePOL.Name = "polePOL";
            this.polePOL.Size = new System.Drawing.Size(0, 29);
            this.polePOL.TabIndex = 10;
            this.polePOL.Click += new System.EventHandler(this.polePOL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 483);
            this.Controls.Add(this.polePOL);
            this.Controls.Add(this.poleLiczba);
            this.Controls.Add(this.poleZodiak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miesiac);
            this.Controls.Add(this.dzien);
            this.Controls.Add(this.btnPodaj);
            this.Name = "Form1";
            this.Text = "Wróżbinator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPodaj;
        private System.Windows.Forms.TextBox dzien;
        private System.Windows.Forms.TextBox miesiac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label poleZodiak;
        private System.Windows.Forms.Label poleLiczba;
        private System.Windows.Forms.Label polePOL;
    }
}

