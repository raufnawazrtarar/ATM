namespace ATM
{
    partial class ATM
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
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.accountNumTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numZeroBtn = new System.Windows.Forms.Button();
            this.numNineBtn = new System.Windows.Forms.Button();
            this.numEightBtn = new System.Windows.Forms.Button();
            this.numSevenBtn = new System.Windows.Forms.Button();
            this.numSixBtn = new System.Windows.Forms.Button();
            this.numFiveBtn = new System.Windows.Forms.Button();
            this.numFourBtn = new System.Windows.Forms.Button();
            this.numThreeBtn = new System.Windows.Forms.Button();
            this.numTwoBtn = new System.Windows.Forms.Button();
            this.numOneBtn = new System.Windows.Forms.Button();
            this.wrongInputLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.Location = new System.Drawing.Point(264, 71);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(351, 20);
            this.instructionsLbl.TabIndex = 1;
            this.instructionsLbl.Text = "Please type in your account number";
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accountNumTextbox
            // 
            this.accountNumTextbox.Location = new System.Drawing.Point(268, 123);
            this.accountNumTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountNumTextbox.MaxLength = 6;
            this.accountNumTextbox.Name = "accountNumTextbox";
            this.accountNumTextbox.Size = new System.Drawing.Size(347, 22);
            this.accountNumTextbox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.enterBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.numZeroBtn);
            this.panel1.Controls.Add(this.numNineBtn);
            this.panel1.Controls.Add(this.numEightBtn);
            this.panel1.Controls.Add(this.numSevenBtn);
            this.panel1.Controls.Add(this.numSixBtn);
            this.panel1.Controls.Add(this.numFiveBtn);
            this.panel1.Controls.Add(this.numFourBtn);
            this.panel1.Controls.Add(this.numThreeBtn);
            this.panel1.Controls.Add(this.numTwoBtn);
            this.panel1.Controls.Add(this.numOneBtn);
            this.panel1.Location = new System.Drawing.Point(201, 404);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 284);
            this.panel1.TabIndex = 3;
            // 
            // enterBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.enterBtn.Location = new System.Drawing.Point(308, 117);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.enterBtn.BackgroundImage = global::ATM.Properties.Resources.enter1;
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterBtn.Location = new System.Drawing.Point(411, 144);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.enterBtn.Location = new System.Drawing.Point(411, 144);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(115, 66);
            this.enterBtn.TabIndex = 12;
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // clearBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.clearBtn.Location = new System.Drawing.Point(308, 58);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.clearBtn.BackgroundImage = global::ATM.Properties.Resources.clear;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Location = new System.Drawing.Point(411, 71);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.clearBtn.Location = new System.Drawing.Point(411, 71);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 66);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.cancelBtn.Location = new System.Drawing.Point(308, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.cancelBtn.BackgroundImage = global::ATM.Properties.Resources.cancel1;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Location = new System.Drawing.Point(411, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.cancelBtn.Location = new System.Drawing.Point(411, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 66);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // numZeroBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numZeroBtn.Location = new System.Drawing.Point(91, 176);
            this.numZeroBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numZeroBtn.BackgroundImage = global::ATM.Properties.Resources.button0;
            this.numZeroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numZeroBtn.Location = new System.Drawing.Point(121, 217);
            this.numZeroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numZeroBtn.Location = new System.Drawing.Point(121, 217);
            this.numZeroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numZeroBtn.Name = "numZeroBtn";
            this.numZeroBtn.Size = new System.Drawing.Size(115, 66);
            this.numZeroBtn.TabIndex = 9;
            this.numZeroBtn.UseVisualStyleBackColor = true;
            this.numZeroBtn.Click += new System.EventHandler(this.numZeroBtn_Click);
            // 
            // numNineBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numNineBtn.Location = new System.Drawing.Point(182, 117);
            this.numNineBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numNineBtn.BackgroundImage = global::ATM.Properties.Resources.button9;
            this.numNineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numNineBtn.Location = new System.Drawing.Point(243, 144);
            this.numNineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numNineBtn.Location = new System.Drawing.Point(243, 144);
            this.numNineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numNineBtn.Name = "numNineBtn";
            this.numNineBtn.Size = new System.Drawing.Size(115, 66);
            this.numNineBtn.TabIndex = 8;
            this.numNineBtn.UseVisualStyleBackColor = true;
            this.numNineBtn.Click += new System.EventHandler(this.numNineBtn_Click);
            // 
            // numEightBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numEightBtn.Location = new System.Drawing.Point(91, 117);
            this.numEightBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numEightBtn.BackgroundImage = global::ATM.Properties.Resources.button8;
            this.numEightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numEightBtn.Location = new System.Drawing.Point(121, 144);
            this.numEightBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numEightBtn.Location = new System.Drawing.Point(121, 144);
            this.numEightBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numEightBtn.Name = "numEightBtn";
            this.numEightBtn.Size = new System.Drawing.Size(115, 66);
            this.numEightBtn.TabIndex = 7;
            this.numEightBtn.UseVisualStyleBackColor = true;
            this.numEightBtn.Click += new System.EventHandler(this.numEightBtn_Click);
            // 
            // numSevenBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numSevenBtn.Location = new System.Drawing.Point(0, 117);
            this.numSevenBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numSevenBtn.BackgroundImage = global::ATM.Properties.Resources.button7;
            this.numSevenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numSevenBtn.Location = new System.Drawing.Point(0, 144);
            this.numSevenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numSevenBtn.Location = new System.Drawing.Point(0, 144);
            this.numSevenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numSevenBtn.Name = "numSevenBtn";
            this.numSevenBtn.Size = new System.Drawing.Size(115, 66);
            this.numSevenBtn.TabIndex = 6;
            this.numSevenBtn.UseVisualStyleBackColor = true;
            this.numSevenBtn.Click += new System.EventHandler(this.numSevenBtn_Click);
            // 
            // numSixBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numSixBtn.Location = new System.Drawing.Point(182, 58);
            this.numSixBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numSixBtn.BackgroundImage = global::ATM.Properties.Resources.button6;
            this.numSixBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numSixBtn.Location = new System.Drawing.Point(243, 71);
            this.numSixBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numSixBtn.Location = new System.Drawing.Point(243, 71);
            this.numSixBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numSixBtn.Name = "numSixBtn";
            this.numSixBtn.Size = new System.Drawing.Size(115, 66);
            this.numSixBtn.TabIndex = 5;
            this.numSixBtn.UseVisualStyleBackColor = true;
            this.numSixBtn.Click += new System.EventHandler(this.numSixBtn_Click);
            // 
            // numFiveBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numFiveBtn.Location = new System.Drawing.Point(91, 58);
            this.numFiveBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numFiveBtn.BackgroundImage = global::ATM.Properties.Resources.button5;
            this.numFiveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numFiveBtn.Location = new System.Drawing.Point(121, 71);
            this.numFiveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numFiveBtn.Location = new System.Drawing.Point(121, 71);
            this.numFiveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numFiveBtn.Name = "numFiveBtn";
            this.numFiveBtn.Size = new System.Drawing.Size(115, 66);
            this.numFiveBtn.TabIndex = 4;
            this.numFiveBtn.UseVisualStyleBackColor = true;
            this.numFiveBtn.Click += new System.EventHandler(this.numFiveBtn_Click);
            // 
            // numFourBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numFourBtn.Location = new System.Drawing.Point(0, 58);
            this.numFourBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numFourBtn.BackgroundImage = global::ATM.Properties.Resources.button4;
            this.numFourBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numFourBtn.Location = new System.Drawing.Point(0, 71);
            this.numFourBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numFourBtn.Location = new System.Drawing.Point(0, 71);
            this.numFourBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numFourBtn.Name = "numFourBtn";
            this.numFourBtn.Size = new System.Drawing.Size(115, 66);
            this.numFourBtn.TabIndex = 3;
            this.numFourBtn.UseVisualStyleBackColor = true;
            this.numFourBtn.Click += new System.EventHandler(this.numFourBtn_Click);
            // 
            // numThreeBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numThreeBtn.Location = new System.Drawing.Point(182, 0);
            this.numThreeBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numThreeBtn.BackgroundImage = global::ATM.Properties.Resources.button3;
            this.numThreeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numThreeBtn.Location = new System.Drawing.Point(243, 0);
            this.numThreeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numThreeBtn.Location = new System.Drawing.Point(243, 0);
            this.numThreeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numThreeBtn.Name = "numThreeBtn";
            this.numThreeBtn.Size = new System.Drawing.Size(115, 66);
            this.numThreeBtn.TabIndex = 2;
            this.numThreeBtn.UseVisualStyleBackColor = true;
            this.numThreeBtn.Click += new System.EventHandler(this.numThreeBtn_Click);
            // 
            // numTwoBtn
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.numTwoBtn.Location = new System.Drawing.Point(91, 0);
            this.numTwoBtn.Margin = new System.Windows.Forms.Padding(2);
=======
            this.numTwoBtn.BackgroundImage = global::ATM.Properties.Resources.button2;
            this.numTwoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numTwoBtn.Location = new System.Drawing.Point(121, 0);
            this.numTwoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b72a55c62deeb00d886cbc11bed9a3c79e53b37e
=======
            this.numTwoBtn.Location = new System.Drawing.Point(121, 0);
            this.numTwoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> parent of 34bb541... Added Semaphore
            this.numTwoBtn.Name = "numTwoBtn";
            this.numTwoBtn.Size = new System.Drawing.Size(115, 66);
            this.numTwoBtn.TabIndex = 1;
            this.numTwoBtn.UseVisualStyleBackColor = true;
            this.numTwoBtn.Click += new System.EventHandler(this.numTwoBtn_Click);
            // 
            // numOneBtn
            // 
            this.numOneBtn.BackgroundImage = global::ATM.Properties.Resources.button1;
            this.numOneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numOneBtn.Location = new System.Drawing.Point(0, 0);
            this.numOneBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOneBtn.Name = "numOneBtn";
            this.numOneBtn.Size = new System.Drawing.Size(115, 66);
            this.numOneBtn.TabIndex = 0;
            this.numOneBtn.UseVisualStyleBackColor = true;
            this.numOneBtn.Click += new System.EventHandler(this.numOneBtn_Click);
            // 
            // wrongInputLbl
            // 
            this.wrongInputLbl.AutoSize = true;
            this.wrongInputLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongInputLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongInputLbl.Location = new System.Drawing.Point(244, 196);
            this.wrongInputLbl.Name = "wrongInputLbl";
            this.wrongInputLbl.Size = new System.Drawing.Size(404, 20);
            this.wrongInputLbl.TabIndex = 5;
            this.wrongInputLbl.Text = "Wrong Account number. Please try again ";
            this.wrongInputLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.bgImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 688);
            this.Controls.Add(this.wrongInputLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountNumTextbox);
            this.Controls.Add(this.instructionsLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.TextBox accountNumTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button numZeroBtn;
        private System.Windows.Forms.Button numNineBtn;
        private System.Windows.Forms.Button numEightBtn;
        private System.Windows.Forms.Button numSevenBtn;
        private System.Windows.Forms.Button numSixBtn;
        private System.Windows.Forms.Button numFiveBtn;
        private System.Windows.Forms.Button numFourBtn;
        private System.Windows.Forms.Button numThreeBtn;
        private System.Windows.Forms.Button numTwoBtn;
        private System.Windows.Forms.Button numOneBtn;
        private System.Windows.Forms.Label wrongInputLbl;
    }
}