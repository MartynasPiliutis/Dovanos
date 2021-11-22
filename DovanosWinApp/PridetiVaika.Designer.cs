
namespace DovanosWinApp
{
    partial class addVaika
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
            this.addChild = new System.Windows.Forms.Button();
            this.textBox_prideti_varda = new System.Windows.Forms.TextBox();
            this.textBox_prideti_pavarde = new System.Windows.Forms.TextBox();
            this.vardas = new System.Windows.Forms.Label();
            this.pavarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addChild
            // 
            this.addChild.Location = new System.Drawing.Point(140, 109);
            this.addChild.Name = "addChild";
            this.addChild.Size = new System.Drawing.Size(75, 23);
            this.addChild.TabIndex = 0;
            this.addChild.Text = "Prideti Vaiką";
            this.addChild.UseVisualStyleBackColor = true;
            this.addChild.Click += new System.EventHandler(this.addChild_Click);
            // 
            // textBox_prideti_varda
            // 
            this.textBox_prideti_varda.Location = new System.Drawing.Point(43, 67);
            this.textBox_prideti_varda.Name = "textBox_prideti_varda";
            this.textBox_prideti_varda.Size = new System.Drawing.Size(100, 20);
            this.textBox_prideti_varda.TabIndex = 1;
            this.textBox_prideti_varda.TextChanged += new System.EventHandler(this.textBox_prideti_varda_TextChanged);
            // 
            // textBox_prideti_pavarde
            // 
            this.textBox_prideti_pavarde.Location = new System.Drawing.Point(221, 67);
            this.textBox_prideti_pavarde.Name = "textBox_prideti_pavarde";
            this.textBox_prideti_pavarde.Size = new System.Drawing.Size(100, 20);
            this.textBox_prideti_pavarde.TabIndex = 2;
            // 
            // vardas
            // 
            this.vardas.AutoSize = true;
            this.vardas.Location = new System.Drawing.Point(40, 51);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(40, 13);
            this.vardas.TabIndex = 3;
            this.vardas.Text = "Vardas";
            // 
            // pavarde
            // 
            this.pavarde.AutoSize = true;
            this.pavarde.Location = new System.Drawing.Point(218, 51);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(47, 13);
            this.pavarde.TabIndex = 4;
            this.pavarde.Text = "Pavardė";
            // 
            // addVaika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.vardas);
            this.Controls.Add(this.textBox_prideti_pavarde);
            this.Controls.Add(this.textBox_prideti_varda);
            this.Controls.Add(this.addChild);
            this.Name = "addVaika";
            this.Text = "Pridėti Vaiką";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addChild;
        private System.Windows.Forms.TextBox textBox_prideti_varda;
        private System.Windows.Forms.TextBox textBox_prideti_pavarde;
        private System.Windows.Forms.Label vardas;
        private System.Windows.Forms.Label pavarde;
    }
}