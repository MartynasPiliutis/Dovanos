
namespace DovanosWinApp
{
    partial class dovanosApp
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
            this.btn_add_vaika = new System.Windows.Forms.Button();
            this.btn_trinti_vaika = new System.Windows.Forms.Button();
            this.btn_add_dovana = new System.Windows.Forms.Button();
            this.textBox_vaikai = new System.Windows.Forms.ListBox();
            this.textBox_dovanos = new System.Windows.Forms.ListBox();
            this.ziuretDovanas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_vaika
            // 
            this.btn_add_vaika.Location = new System.Drawing.Point(18, 186);
            this.btn_add_vaika.Name = "btn_add_vaika";
            this.btn_add_vaika.Size = new System.Drawing.Size(100, 20);
            this.btn_add_vaika.TabIndex = 2;
            this.btn_add_vaika.Text = "Pridėti vaiką";
            this.btn_add_vaika.UseVisualStyleBackColor = true;
            this.btn_add_vaika.Click += new System.EventHandler(this.btn_add_vaika_Click);
            // 
            // btn_trinti_vaika
            // 
            this.btn_trinti_vaika.Location = new System.Drawing.Point(168, 186);
            this.btn_trinti_vaika.Name = "btn_trinti_vaika";
            this.btn_trinti_vaika.Size = new System.Drawing.Size(100, 20);
            this.btn_trinti_vaika.TabIndex = 3;
            this.btn_trinti_vaika.Text = "Ištrinti";
            this.btn_trinti_vaika.UseVisualStyleBackColor = true;
            this.btn_trinti_vaika.Click += new System.EventHandler(this.btn_trinti_vaika_Click);
            // 
            // btn_add_dovana
            // 
            this.btn_add_dovana.Location = new System.Drawing.Point(18, 419);
            this.btn_add_dovana.Name = "btn_add_dovana";
            this.btn_add_dovana.Size = new System.Drawing.Size(100, 20);
            this.btn_add_dovana.TabIndex = 6;
            this.btn_add_dovana.Text = "Pridėti dovaną";
            this.btn_add_dovana.UseVisualStyleBackColor = true;
            this.btn_add_dovana.Click += new System.EventHandler(this.btn_add_dovana_Click);
            // 
            // textBox_vaikai
            // 
            this.textBox_vaikai.ColumnWidth = 100;
            this.textBox_vaikai.FormattingEnabled = true;
            this.textBox_vaikai.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox_vaikai.Location = new System.Drawing.Point(18, 20);
            this.textBox_vaikai.MaximumSize = new System.Drawing.Size(250, 160);
            this.textBox_vaikai.Name = "textBox_vaikai";
            this.textBox_vaikai.ScrollAlwaysVisible = true;
            this.textBox_vaikai.Size = new System.Drawing.Size(250, 160);
            this.textBox_vaikai.TabIndex = 7;
            this.textBox_vaikai.SelectedIndexChanged += new System.EventHandler(this.textBox_vaikai_SelectedIndexChanged);
            // 
            // textBox_dovanos
            // 
            this.textBox_dovanos.ColumnWidth = 100;
            this.textBox_dovanos.FormattingEnabled = true;
            this.textBox_dovanos.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox_dovanos.Location = new System.Drawing.Point(18, 253);
            this.textBox_dovanos.MaximumSize = new System.Drawing.Size(250, 160);
            this.textBox_dovanos.Name = "textBox_dovanos";
            this.textBox_dovanos.ScrollAlwaysVisible = true;
            this.textBox_dovanos.Size = new System.Drawing.Size(250, 160);
            this.textBox_dovanos.TabIndex = 8;
            // 
            // ziuretDovanas
            // 
            this.ziuretDovanas.Location = new System.Drawing.Point(92, 212);
            this.ziuretDovanas.Name = "ziuretDovanas";
            this.ziuretDovanas.Size = new System.Drawing.Size(100, 20);
            this.ziuretDovanas.TabIndex = 9;
            this.ziuretDovanas.Text = "Pažiūrėti dovanas";
            this.ziuretDovanas.UseVisualStyleBackColor = true;
            this.ziuretDovanas.Click += new System.EventHandler(this.ziuretDovanas_Click);
            // 
            // dovanosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.ziuretDovanas);
            this.Controls.Add(this.textBox_dovanos);
            this.Controls.Add(this.textBox_vaikai);
            this.Controls.Add(this.btn_add_dovana);
            this.Controls.Add(this.btn_trinti_vaika);
            this.Controls.Add(this.btn_add_vaika);
            this.Name = "dovanosApp";
            this.Text = "Dovanos Vaikams";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add_vaika;
        private System.Windows.Forms.Button btn_trinti_vaika;
        private System.Windows.Forms.Button btn_add_dovana;
        private System.Windows.Forms.ListBox textBox_vaikai;
        private System.Windows.Forms.ListBox textBox_dovanos;
        private System.Windows.Forms.Button ziuretDovanas;
    }
}

