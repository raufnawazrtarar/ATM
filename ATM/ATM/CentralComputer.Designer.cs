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
            this.openedATMDisplayLbl = new System.Windows.Forms.Label();
            this.openATMsNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openNewATM
            // 
            this.openNewATM.Font = new System.Drawing.Font("Verdana Pro Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNewATM.Location = new System.Drawing.Point(316, 308);
            this.openNewATM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openNewATM.Name = "openNewATM";
            this.openNewATM.Size = new System.Drawing.Size(137, 55);
            this.openNewATM.TabIndex = 0;
            this.openNewATM.Text = "Open New ATM with Semaphore";
            this.openNewATM.UseVisualStyleBackColor = true;
            this.openNewATM.Click += new System.EventHandler(this.openNewATM_Click);
            // 
            // shutDownBtn
            // 
            this.shutDownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shutDownBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutDownBtn.Location = new System.Drawing.Point(15, 308);
            this.shutDownBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shutDownBtn.Name = "shutDownBtn";
            this.shutDownBtn.Size = new System.Drawing.Size(148, 55);
            this.shutDownBtn.TabIndex = 1;
            this.shutDownBtn.Text = "Shut Down the System";
            this.shutDownBtn.UseVisualStyleBackColor = true;
            this.shutDownBtn.Click += new System.EventHandler(this.shutDownBtn_Click);
            // 
            // openATMwithout
            // 
            this.openATMwithout.Font = new System.Drawing.Font("Arial Nova Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openATMwithout.Location = new System.Drawing.Point(168, 308);
            this.openATMwithout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openATMwithout.Name = "openATMwithout";
            this.openATMwithout.Size = new System.Drawing.Size(143, 55);
            this.openATMwithout.TabIndex = 2;
            this.openATMwithout.Text = "Open an ATM without Semaphore";
            this.openATMwithout.UseVisualStyleBackColor = true;
            this.openATMwithout.Click += new System.EventHandler(this.openATMwithout_Click);
            // 
            // openedATMDisplayLbl
            // 
            this.openedATMDisplayLbl.AutoSize = true;
            this.openedATMDisplayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedATMDisplayLbl.Location = new System.Drawing.Point(50, 30);
            this.openedATMDisplayLbl.Name = "openedATMDisplayLbl";
            this.openedATMDisplayLbl.Size = new System.Drawing.Size(160, 25);
            this.openedATMDisplayLbl.TabIndex = 3;
            this.openedATMDisplayLbl.Text = "Opened ATMs:";
            // 
            // openATMsNumLbl
            // 
            this.openATMsNumLbl.AutoSize = true;
            this.openATMsNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openATMsNumLbl.Location = new System.Drawing.Point(240, 30);
            this.openATMsNumLbl.Name = "openATMsNumLbl";
            this.openATMsNumLbl.Size = new System.Drawing.Size(0, 25);
            this.openATMsNumLbl.TabIndex = 4;
            // 
            // CentralComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ATM.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(468, 372);
            this.Controls.Add(this.openATMsNumLbl);
            this.Controls.Add(this.openedATMDisplayLbl);
            this.Controls.Add(this.openATMwithout);
            this.Controls.Add(this.shutDownBtn);
            this.Controls.Add(this.openNewATM);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CentralComputer";
            this.Text = "Central Computer";
            this.Load += new System.EventHandler(this.CentralComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openNewATM;
        private System.Windows.Forms.Button shutDownBtn;
        private System.Windows.Forms.Button openATMwithout;
        private System.Windows.Forms.Label openedATMDisplayLbl;
        private System.Windows.Forms.Label openATMsNumLbl;
    }
}

