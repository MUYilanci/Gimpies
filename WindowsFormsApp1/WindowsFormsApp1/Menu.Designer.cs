namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Verkoop = new System.Windows.Forms.Button();
            this.Bekijken = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Wijzigen = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Verkoop
            // 
            this.Verkoop.Location = new System.Drawing.Point(233, 66);
            this.Verkoop.Name = "Verkoop";
            this.Verkoop.Size = new System.Drawing.Size(89, 37);
            this.Verkoop.TabIndex = 0;
            this.Verkoop.Text = "Verkoop Registreren";
            this.Verkoop.UseVisualStyleBackColor = true;
            this.Verkoop.Click += new System.EventHandler(this.Verkoop_Click);
            // 
            // Bekijken
            // 
            this.Bekijken.Location = new System.Drawing.Point(233, 109);
            this.Bekijken.Name = "Bekijken";
            this.Bekijken.Size = new System.Drawing.Size(89, 37);
            this.Bekijken.TabIndex = 1;
            this.Bekijken.Text = "Artikel Bekijken";
            this.Bekijken.UseVisualStyleBackColor = true;
            this.Bekijken.Click += new System.EventHandler(this.Bekijken_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(422, 220);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(74, 29);
            this.logout.TabIndex = 2;
            this.logout.Text = "Exit";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.afsluiten_Click);
            // 
            // Wijzigen
            // 
            this.Wijzigen.Location = new System.Drawing.Point(233, 152);
            this.Wijzigen.Name = "Wijzigen";
            this.Wijzigen.Size = new System.Drawing.Size(89, 37);
            this.Wijzigen.TabIndex = 3;
            this.Wijzigen.Text = "Artikel Wijzigen";
            this.Wijzigen.UseVisualStyleBackColor = true;
            this.Wijzigen.Click += new System.EventHandler(this.Wijzigen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 237);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(228, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Homepage";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Uitloggen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Uitloggen_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(508, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Wijzigen);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Bekijken);
            this.Controls.Add(this.Verkoop);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verkoop;
        private System.Windows.Forms.Button Bekijken;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Wijzigen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}