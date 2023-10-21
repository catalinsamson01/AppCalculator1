namespace AppCalculator1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnAdunare = new System.Windows.Forms.Button();
            this.btnScadere = new System.Windows.Forms.Button();
            this.btnInmultire = new System.Windows.Forms.Button();
            this.btnImpartire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "B =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(207, 32);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 45);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(207, 95);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 45);
            this.txtB.TabIndex = 3;
            // 
            // btnAdunare
            // 
            this.btnAdunare.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdunare.Location = new System.Drawing.Point(62, 258);
            this.btnAdunare.Name = "btnAdunare";
            this.btnAdunare.Size = new System.Drawing.Size(134, 64);
            this.btnAdunare.TabIndex = 4;
            this.btnAdunare.Text = "+";
            this.btnAdunare.UseVisualStyleBackColor = true;
            this.btnAdunare.Click += new System.EventHandler(this.btnAdunare_Click);
            // 
            // btnScadere
            // 
            this.btnScadere.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScadere.Location = new System.Drawing.Point(207, 258);
            this.btnScadere.Name = "btnScadere";
            this.btnScadere.Size = new System.Drawing.Size(138, 62);
            this.btnScadere.TabIndex = 5;
            this.btnScadere.Text = "-";
            this.btnScadere.UseVisualStyleBackColor = true;
            this.btnScadere.Click += new System.EventHandler(this.btnScadere_Click);
            // 
            // btnInmultire
            // 
            this.btnInmultire.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInmultire.Location = new System.Drawing.Point(371, 258);
            this.btnInmultire.Name = "btnInmultire";
            this.btnInmultire.Size = new System.Drawing.Size(128, 62);
            this.btnInmultire.TabIndex = 6;
            this.btnInmultire.Text = "*";
            this.btnInmultire.UseVisualStyleBackColor = true;
            this.btnInmultire.Click += new System.EventHandler(this.btnInmultire_Click);
            // 
            // btnImpartire
            // 
            this.btnImpartire.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpartire.Location = new System.Drawing.Point(539, 258);
            this.btnImpartire.Name = "btnImpartire";
            this.btnImpartire.Size = new System.Drawing.Size(140, 62);
            this.btnImpartire.TabIndex = 7;
            this.btnImpartire.Text = "/";
            this.btnImpartire.UseVisualStyleBackColor = true;
            this.btnImpartire.Click += new System.EventHandler(this.btnImpartire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::AppCalculator1.Properties.Resources.space_astronaut_meteors_earth_beer_carlsberg_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImpartire);
            this.Controls.Add(this.btnInmultire);
            this.Controls.Add(this.btnScadere);
            this.Controls.Add(this.btnAdunare);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULATOR SMART";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnAdunare;
        private System.Windows.Forms.Button btnScadere;
        private System.Windows.Forms.Button btnInmultire;
        private System.Windows.Forms.Button btnImpartire;
    }
}

