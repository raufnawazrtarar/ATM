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
            this.SuspendLayout();
            // 
            // openNewATM
            // 
            this.openNewATM.Location = new System.Drawing.Point(22, 301);
            this.openNewATM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openNewATM.Name = "openNewATM";
            this.openNewATM.Size = new System.Drawing.Size(92, 45);
            this.openNewATM.TabIndex = 0;
            this.openNewATM.Text = "Open New ATM";
            this.openNewATM.UseVisualStyleBackColor = true;
            this.openNewATM.Click += new System.EventHandler(this.openNewATM_Click);
            // 
            // CentralComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(351, 366);
            this.Controls.Add(this.openNewATM);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CentralComputer";
            this.Text = "Central Computer";
            this.Load += new System.EventHandler(this.CentralComputer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNewATM;
    }
}

