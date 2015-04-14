namespace Password_Generator
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.LinkLabel();
            this.diceware = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Securely generates passwords using\r\n the Diceware  technique and C#\'s RNGCryptoSe" +
    "rviceProvider.\r\n\r\nSource code available at github.com/bubnick/PasswordGenerator\r" +
    "\nCreated by bubnick.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Location = new System.Drawing.Point(135, 48);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(200, 13);
            this.github.TabIndex = 2;
            this.github.TabStop = true;
            this.github.Text = "github.com/bubnick/PasswordGenerator";
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // diceware
            // 
            this.diceware.AutoSize = true;
            this.diceware.Location = new System.Drawing.Point(41, 22);
            this.diceware.Name = "diceware";
            this.diceware.Size = new System.Drawing.Size(52, 13);
            this.diceware.TabIndex = 3;
            this.diceware.TabStop = true;
            this.diceware.Text = "Diceware";
            this.diceware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.diceware_LinkClicked);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 128);
            this.Controls.Add(this.diceware);
            this.Controls.Add(this.github);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.LinkLabel diceware;
    }
}