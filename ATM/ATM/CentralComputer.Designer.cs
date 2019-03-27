namespace ATM
{
    partial class CentralComputer
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
            this.openNewATM = new System.Windows.Forms.Button();
            this.shutDownBtn = new System.Windows.Forms.Button();
            this.openATMwithout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openNewATM
            // 
            this.openNewATM.Location = new System.Drawing.Point(237, 250);
            this.openNewATM.Margin = new System.Windows.Forms.Padding(2);
            this.openNewATM.Name = "openNewATM";
            this.openNewATM.Size = new System.Drawing.Size(103, 45);
            this.openNewATM.TabIndex = 0;
            this.openNewATM.Text = "Open New ATM with Semaphore";
            this.openNewATM.UseVisualStyleBackColor = true;
            this.openNewATM.Click += new System.EventHandler(this.openNewATM_Click);
            // 
            // shutDownBtn
            // 
            this.shutDownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shutDownBtn.Location = new System.Drawing.Point(11, 250);
            this.shutDownBtn.Margin = new System.Windows.Forms.Padding(2);
            this.shutDownBtn.Name = "shutDownBtn";
            this.shutDownBtn.Size = new System.Drawing.Size(111, 45);
            this.shutDownBtn.TabIndex = 1;
            this.shutDownBtn.Text = "Shut Down the System";
            this.shutDownBtn.UseVisualStyleBackColor = true;
            this.shutDownBtn.Click += new System.EventHandler(this.shutDownBtn_Click);
            // 
            // openATMwithout
            // 
            this.openATMwithout.Location = new System.Drawing.Point(126, 250);
            this.openATMwithout.Margin = new System.Windows.Forms.Padding(2);
            this.openATMwithout.Name = "openATMwithout";
            this.openATMwithout.Size = new System.Drawing.Size(107, 45);
            this.openATMwithout.TabIndex = 2;
            this.openATMwithout.Text = "Open an ATM without Semaphore";
            this.openATMwithout.UseVisualStyleBackColor = true;
            this.openATMwithout.Click += new System.EventHandler(this.openATMwithout_Click);
            // 
            // CentralComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ATM.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(351, 302);
            this.Controls.Add(this.openATMwithout);
            this.Controls.Add(this.shutDownBtn);
            this.Controls.Add(this.openNewATM);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CentralComputer";
            this.Text = "Central Computer";
            this.Load += new System.EventHandler(this.CentralComputer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNewATM;
        private System.Windows.Forms.Button shutDownBtn;
        private System.Windows.Forms.Button openATMwithout;
    }
}

