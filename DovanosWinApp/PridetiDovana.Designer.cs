
namespace DovanosWinApp
{
    partial class naujaDovana
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
            this.textBox_nauja_dovana = new System.Windows.Forms.TextBox();
            this.button_add_dovana = new System.Windows.Forms.Button();
            this.vaikoId = new System.Windows.Forms.Label();
            this.dovana = new System.Windows.Forms.Label();
            this.textBox_vaikoId_nDovana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_nauja_dovana
            // 
            this.textBox_nauja_dovana.Location = new System.Drawing.Point(67, 61);
            this.textBox_nauja_dovana.Name = "textBox_nauja_dovana";
            this.textBox_nauja_dovana.Size = new System.Drawing.Size(242, 20);
            this.textBox_nauja_dovana.TabIndex = 0;
            // 
            // button_add_dovana
            // 
            this.button_add_dovana.Location = new System.Drawing.Point(149, 100);
            this.button_add_dovana.Name = "button_add_dovana";
            this.button_add_dovana.Size = new System.Drawing.Size(75, 23);
            this.button_add_dovana.TabIndex = 1;
            this.button_add_dovana.Text = "Pridėti Dovaną";
            this.button_add_dovana.UseVisualStyleBackColor = true;
            this.button_add_dovana.Click += new System.EventHandler(this.button_add_dovana_Click);
            // 
            // vaikoId
            // 
            this.vaikoId.AutoSize = true;
            this.vaikoId.Location = new System.Drawing.Point(12, 29);
            this.vaikoId.Name = "vaikoId";
            this.vaikoId.Size = new System.Drawing.Size(48, 13);
            this.vaikoId.TabIndex = 2;
            this.vaikoId.Text = "Vaiko ID";
            // 
            // dovana
            // 
            this.dovana.AutoSize = true;
            this.dovana.Location = new System.Drawing.Point(12, 64);
            this.dovana.Name = "dovana";
            this.dovana.Size = new System.Drawing.Size(45, 13);
            this.dovana.TabIndex = 3;
            this.dovana.Text = "Dovana";
            // 
            // textBox_vaikoId_nDovana
            // 
            this.textBox_vaikoId_nDovana.Location = new System.Drawing.Point(66, 26);
            this.textBox_vaikoId_nDovana.Name = "textBox_vaikoId_nDovana";
            this.textBox_vaikoId_nDovana.Size = new System.Drawing.Size(100, 20);
            this.textBox_vaikoId_nDovana.TabIndex = 4;
            // 
            // naujaDovana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.textBox_vaikoId_nDovana);
            this.Controls.Add(this.dovana);
            this.Controls.Add(this.vaikoId);
            this.Controls.Add(this.button_add_dovana);
            this.Controls.Add(this.textBox_nauja_dovana);
            this.Name = "naujaDovana";
            this.Text = "Nauja Dovana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nauja_dovana;
        private System.Windows.Forms.Button button_add_dovana;
        private System.Windows.Forms.Label vaikoId;
        private System.Windows.Forms.Label dovana;
        private System.Windows.Forms.TextBox textBox_vaikoId_nDovana;
    }
}