namespace LogistykaTransport
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddDostawca = new System.Windows.Forms.Button();
            this.AddOdbiorca = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddCeny = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 316);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // AddDostawca
            // 
            this.AddDostawca.Location = new System.Drawing.Point(625, 15);
            this.AddDostawca.Name = "AddDostawca";
            this.AddDostawca.Size = new System.Drawing.Size(163, 23);
            this.AddDostawca.TabIndex = 1;
            this.AddDostawca.Text = "Dodaj Dostawcę";
            this.AddDostawca.UseVisualStyleBackColor = true;
            this.AddDostawca.Click += new System.EventHandler(this.AddDostawca_Click);
            // 
            // AddOdbiorca
            // 
            this.AddOdbiorca.Location = new System.Drawing.Point(625, 44);
            this.AddOdbiorca.Name = "AddOdbiorca";
            this.AddOdbiorca.Size = new System.Drawing.Size(163, 23);
            this.AddOdbiorca.TabIndex = 1;
            this.AddOdbiorca.Text = "Dodaj Odbiorcę";
            this.AddOdbiorca.UseVisualStyleBackColor = true;
            this.AddOdbiorca.Click += new System.EventHandler(this.AddOdbiorca_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(93, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(526, 26);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 47);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(84, 313);
            this.flowLayoutPanel4.TabIndex = 0;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // AddCeny
            // 
            this.AddCeny.Location = new System.Drawing.Point(625, 73);
            this.AddCeny.Name = "AddCeny";
            this.AddCeny.Size = new System.Drawing.Size(163, 23);
            this.AddCeny.TabIndex = 0;
            this.AddCeny.Text = "Podaż / Popyt";
            this.AddCeny.UseVisualStyleBackColor = true;
            this.AddCeny.Click += new System.EventHandler(this.AddCeny_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(625, 102);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(163, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Oblicz";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Zamknij";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.AddCeny);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.AddOdbiorca);
            this.Controls.Add(this.AddDostawca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddDostawca;
        private System.Windows.Forms.Button AddOdbiorca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button AddCeny;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button ExitButton;
    }
}

