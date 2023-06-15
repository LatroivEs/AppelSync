namespace AppelSync.Help
{
    partial class iTunesXMLHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iTunesXMLHelp));
            this.HelpText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HelpText.Location = new System.Drawing.Point(82, 28);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(1198, 45);
            this.HelpText.TabIndex = 0;
            this.HelpText.Text = "Para poder sincronizar las canciones es necesario que iTunes tenga habilitado el";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(82, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1198, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para ello seleccione Edicion => Preferencias => Avanzado => ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(82, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1198, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "=> Compartir el XML de la Biblioteca de iTunes con otras aplicaciones.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(42, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1266, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(82, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1198, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reinicie el iTunes.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(82, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1198, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "La carpeta donde esta instalado el iTunes se puede ver en dicha pestaña.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(82, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1198, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "XML para terceros.";
            // 
            // iTunesXMLHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1347, 1229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iTunesXMLHelp";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habilitar XML itunes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelpText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}