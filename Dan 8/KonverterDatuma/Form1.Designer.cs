namespace KonverterDatuma
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
            this.tbxUlaz = new System.Windows.Forms.TextBox();
            this.tbxIzlaz = new System.Windows.Forms.TextBox();
            this.lblUlaz = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.btnKonvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUlaz
            // 
            this.tbxUlaz.Location = new System.Drawing.Point(56, 14);
            this.tbxUlaz.Name = "tbxUlaz";
            this.tbxUlaz.Size = new System.Drawing.Size(100, 20);
            this.tbxUlaz.TabIndex = 0;
            this.tbxUlaz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxUlaz_MouseClick);
            // 
            // tbxIzlaz
            // 
            this.tbxIzlaz.Location = new System.Drawing.Point(56, 49);
            this.tbxIzlaz.Name = "tbxIzlaz";
            this.tbxIzlaz.Size = new System.Drawing.Size(100, 20);
            this.tbxIzlaz.TabIndex = 1;
            // 
            // lblUlaz
            // 
            this.lblUlaz.AutoSize = true;
            this.lblUlaz.Location = new System.Drawing.Point(15, 17);
            this.lblUlaz.Name = "lblUlaz";
            this.lblUlaz.Size = new System.Drawing.Size(28, 13);
            this.lblUlaz.TabIndex = 2;
            this.lblUlaz.Text = "Ulaz";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(15, 52);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 3;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // btnKonvert
            // 
            this.btnKonvert.Location = new System.Drawing.Point(66, 75);
            this.btnKonvert.Name = "btnKonvert";
            this.btnKonvert.Size = new System.Drawing.Size(75, 23);
            this.btnKonvert.TabIndex = 4;
            this.btnKonvert.Text = "Konvertuj";
            this.btnKonvert.UseVisualStyleBackColor = true;
            this.btnKonvert.Click += new System.EventHandler(this.btnKonvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 145);
            this.Controls.Add(this.btnKonvert);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblUlaz);
            this.Controls.Add(this.tbxIzlaz);
            this.Controls.Add(this.tbxUlaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUlaz;
        private System.Windows.Forms.TextBox tbxIzlaz;
        private System.Windows.Forms.Label lblUlaz;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Button btnKonvert;
    }
}

