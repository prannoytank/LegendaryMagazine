namespace MetroUiTest
{
    partial class TweeterInput
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
            this.txbTweet = new System.Windows.Forms.TextBox();
            this.btnTweet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbVari = new System.Windows.Forms.TextBox();
            this.btnVari = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTweet
            // 
            this.txbTweet.Location = new System.Drawing.Point(23, 82);
            this.txbTweet.MaxLength = 140;
            this.txbTweet.Multiline = true;
            this.txbTweet.Name = "txbTweet";
            this.txbTweet.Size = new System.Drawing.Size(528, 88);
            this.txbTweet.TabIndex = 0;
            this.txbTweet.TextChanged += new System.EventHandler(this.txbTweet_TextChanged);
            // 
            // btnTweet
            // 
            this.btnTweet.Enabled = false;
            this.btnTweet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTweet.Location = new System.Drawing.Point(476, 253);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(75, 29);
            this.btnTweet.TabIndex = 1;
            this.btnTweet.Text = "Tweet";
            this.btnTweet.UseVisualStyleBackColor = true;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(449, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max 140 Characters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(23, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Verification Code";
            // 
            // txbVari
            // 
            this.txbVari.Location = new System.Drawing.Point(165, 206);
            this.txbVari.Name = "txbVari";
            this.txbVari.Size = new System.Drawing.Size(150, 20);
            this.txbVari.TabIndex = 5;
            // 
            // btnVari
            // 
            this.btnVari.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVari.Location = new System.Drawing.Point(26, 253);
            this.btnVari.Name = "btnVari";
            this.btnVari.Size = new System.Drawing.Size(119, 29);
            this.btnVari.TabIndex = 6;
            this.btnVari.Text = "Get Verification Code";
            this.btnVari.UseVisualStyleBackColor = true;
            this.btnVari.Click += new System.EventHandler(this.btnVari_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCount.Location = new System.Drawing.Point(449, 60);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(81, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Characters left: ";
            // 
            // TweeterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 295);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnVari);
            this.Controls.Add(this.txbVari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTweet);
            this.Controls.Add(this.txbTweet);
            this.Name = "TweeterInput";
            this.Resizable = false;
            this.Text = "Tweet it!";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.Load += new System.EventHandler(this.TweeterInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTweet;
        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbVari;
        private System.Windows.Forms.Button btnVari;
        private System.Windows.Forms.Label lblCount;
    }
}