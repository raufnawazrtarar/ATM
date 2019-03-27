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
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.keypadPnl = new System.Windows.Forms.Panel();
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
            this.option1Lbl = new System.Windows.Forms.Label();
            this.option2Lbl = new System.Windows.Forms.Label();
            this.option3Lbl = new System.Windows.Forms.Label();
            this.option4Lbl = new System.Windows.Forms.Label();
            this.option5Lbl = new System.Windows.Forms.Label();
            this.option6Lbl = new System.Windows.Forms.Label();
            this.option1Btn = new System.Windows.Forms.Button();
            this.option2Btn = new System.Windows.Forms.Button();
            this.option3Btn = new System.Windows.Forms.Button();
            this.option4Btn = new System.Windows.Forms.Button();
            this.option5Btn = new System.Windows.Forms.Button();
            this.option6Btn = new System.Windows.Forms.Button();
            this.keypadPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.Location = new System.Drawing.Point(264, 71);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(351, 20);
            this.instructionsLbl.TabIndex = 1;
            this.instructionsLbl.Text = "Please type in your account number";
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(268, 123);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextbox.MaxLength = 6;
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(347, 22);
            this.loginTextbox.TabIndex = 2;
            // 
            // keypadPnl
            // 
            this.keypadPnl.BackColor = System.Drawing.Color.Silver;
            this.keypadPnl.Controls.Add(this.enterBtn);
            this.keypadPnl.Controls.Add(this.clearBtn);
            this.keypadPnl.Controls.Add(this.cancelBtn);
            this.keypadPnl.Controls.Add(this.numZeroBtn);
            this.keypadPnl.Controls.Add(this.numNineBtn);
            this.keypadPnl.Controls.Add(this.numEightBtn);
            this.keypadPnl.Controls.Add(this.numSevenBtn);
            this.keypadPnl.Controls.Add(this.numSixBtn);
            this.keypadPnl.Controls.Add(this.numFiveBtn);
            this.keypadPnl.Controls.Add(this.numFourBtn);
            this.keypadPnl.Controls.Add(this.numThreeBtn);
            this.keypadPnl.Controls.Add(this.numTwoBtn);
            this.keypadPnl.Controls.Add(this.numOneBtn);
            this.keypadPnl.Location = new System.Drawing.Point(201, 404);
            this.keypadPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadPnl.Name = "keypadPnl";
            this.keypadPnl.Size = new System.Drawing.Size(528, 284);
            this.keypadPnl.TabIndex = 3;
            // 
            // enterBtn
            // 
            this.enterBtn.BackgroundImage = global::ATM.Properties.Resources.enter;
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterBtn.Location = new System.Drawing.Point(411, 144);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(115, 66);
            this.enterBtn.TabIndex = 12;
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = global::ATM.Properties.Resources.clear;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Location = new System.Drawing.Point(411, 71);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 66);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::ATM.Properties.Resources.cancel;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Location = new System.Drawing.Point(411, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 66);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // numZeroBtn
            // 
            this.numZeroBtn.BackgroundImage = global::ATM.Properties.Resources.button0;
            this.numZeroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numZeroBtn.Location = new System.Drawing.Point(121, 217);
            this.numZeroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numZeroBtn.Name = "numZeroBtn";
            this.numZeroBtn.Size = new System.Drawing.Size(115, 66);
            this.numZeroBtn.TabIndex = 9;
            this.numZeroBtn.UseVisualStyleBackColor = true;
            this.numZeroBtn.Click += new System.EventHandler(this.numZeroBtn_Click);
            // 
            // numNineBtn
            // 
            this.numNineBtn.BackgroundImage = global::ATM.Properties.Resources.button9;
            this.numNineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numNineBtn.Location = new System.Drawing.Point(243, 144);
            this.numNineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numNineBtn.Name = "numNineBtn";
            this.numNineBtn.Size = new System.Drawing.Size(115, 66);
            this.numNineBtn.TabIndex = 8;
            this.numNineBtn.UseVisualStyleBackColor = true;
            this.numNineBtn.Click += new System.EventHandler(this.numNineBtn_Click);
            // 
            // numEightBtn
            // 
            this.numEightBtn.BackgroundImage = global::ATM.Properties.Resources.button8;
            this.numEightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numEightBtn.Location = new System.Drawing.Point(121, 144);
            this.numEightBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numEightBtn.Name = "numEightBtn";
            this.numEightBtn.Size = new System.Drawing.Size(115, 66);
            this.numEightBtn.TabIndex = 7;
            this.numEightBtn.UseVisualStyleBackColor = true;
            this.numEightBtn.Click += new System.EventHandler(this.numEightBtn_Click);
            // 
            // numSevenBtn
            // 
            this.numSevenBtn.BackgroundImage = global::ATM.Properties.Resources.button7;
            this.numSevenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numSevenBtn.Location = new System.Drawing.Point(0, 144);
            this.numSevenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSevenBtn.Name = "numSevenBtn";
            this.numSevenBtn.Size = new System.Drawing.Size(115, 66);
            this.numSevenBtn.TabIndex = 6;
            this.numSevenBtn.UseVisualStyleBackColor = true;
            this.numSevenBtn.Click += new System.EventHandler(this.numSevenBtn_Click);
            // 
            // numSixBtn
            // 
            this.numSixBtn.BackgroundImage = global::ATM.Properties.Resources.button6;
            this.numSixBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numSixBtn.Location = new System.Drawing.Point(243, 71);
            this.numSixBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSixBtn.Name = "numSixBtn";
            this.numSixBtn.Size = new System.Drawing.Size(115, 66);
            this.numSixBtn.TabIndex = 5;
            this.numSixBtn.UseVisualStyleBackColor = true;
            this.numSixBtn.Click += new System.EventHandler(this.numSixBtn_Click);
            // 
            // numFiveBtn
            // 
            this.numFiveBtn.BackgroundImage = global::ATM.Properties.Resources.button5;
            this.numFiveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numFiveBtn.Location = new System.Drawing.Point(121, 71);
            this.numFiveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFiveBtn.Name = "numFiveBtn";
            this.numFiveBtn.Size = new System.Drawing.Size(115, 66);
            this.numFiveBtn.TabIndex = 4;
            this.numFiveBtn.UseVisualStyleBackColor = true;
            this.numFiveBtn.Click += new System.EventHandler(this.numFiveBtn_Click);
            // 
            // numFourBtn
            // 
            this.numFourBtn.BackgroundImage = global::ATM.Properties.Resources.button4;
            this.numFourBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numFourBtn.Location = new System.Drawing.Point(0, 71);
            this.numFourBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFourBtn.Name = "numFourBtn";
            this.numFourBtn.Size = new System.Drawing.Size(115, 66);
            this.numFourBtn.TabIndex = 3;
            this.numFourBtn.UseVisualStyleBackColor = true;
            this.numFourBtn.Click += new System.EventHandler(this.numFourBtn_Click);
            // 
            // numThreeBtn
            // 
            this.numThreeBtn.BackgroundImage = global::ATM.Properties.Resources.button3;
            this.numThreeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numThreeBtn.Location = new System.Drawing.Point(243, 0);
            this.numThreeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numThreeBtn.Name = "numThreeBtn";
            this.numThreeBtn.Size = new System.Drawing.Size(115, 66);
            this.numThreeBtn.TabIndex = 2;
            this.numThreeBtn.UseVisualStyleBackColor = true;
            this.numThreeBtn.Click += new System.EventHandler(this.numThreeBtn_Click);
            // 
            // numTwoBtn
            // 
            this.numTwoBtn.BackgroundImage = global::ATM.Properties.Resources.button2;
            this.numTwoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numTwoBtn.Location = new System.Drawing.Point(121, 0);
            this.numTwoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.wrongInputLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongInputLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongInputLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongInputLbl.Location = new System.Drawing.Point(244, 196);
            this.wrongInputLbl.Name = "wrongInputLbl";
            this.wrongInputLbl.Size = new System.Drawing.Size(404, 20);
            this.wrongInputLbl.TabIndex = 5;
            this.wrongInputLbl.Text = "Wrong Account number. Please try again ";
            this.wrongInputLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // option1Lbl
            // 
            this.option1Lbl.AutoSize = true;
            this.option1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option1Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Lbl.Location = new System.Drawing.Point(164, 118);
            this.option1Lbl.Name = "option1Lbl";
            this.option1Lbl.Size = new System.Drawing.Size(52, 20);
            this.option1Lbl.TabIndex = 6;
            this.option1Lbl.Text = "label1";
            // 
            // option2Lbl
            // 
            this.option2Lbl.AutoSize = true;
            this.option2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option2Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Lbl.Location = new System.Drawing.Point(164, 214);
            this.option2Lbl.Name = "option2Lbl";
            this.option2Lbl.Size = new System.Drawing.Size(52, 20);
            this.option2Lbl.TabIndex = 7;
            this.option2Lbl.Text = "label2";
            // 
            // option3Lbl
            // 
            this.option3Lbl.AutoSize = true;
            this.option3Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option3Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Lbl.Location = new System.Drawing.Point(164, 310);
            this.option3Lbl.Name = "option3Lbl";
            this.option3Lbl.Size = new System.Drawing.Size(52, 20);
            this.option3Lbl.TabIndex = 8;
            this.option3Lbl.Text = "label3";
            // 
            // option4Lbl
            // 
            this.option4Lbl.AutoSize = true;
            this.option4Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option4Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Lbl.Location = new System.Drawing.Point(705, 118);
            this.option4Lbl.Name = "option4Lbl";
            this.option4Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.option4Lbl.Size = new System.Drawing.Size(52, 20);
            this.option4Lbl.TabIndex = 9;
            this.option4Lbl.Text = "label4";
            this.option4Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // option5Lbl
            // 
            this.option5Lbl.AutoSize = true;
            this.option5Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option5Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option5Lbl.Location = new System.Drawing.Point(705, 214);
            this.option5Lbl.Name = "option5Lbl";
            this.option5Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.option5Lbl.Size = new System.Drawing.Size(52, 20);
            this.option5Lbl.TabIndex = 10;
            this.option5Lbl.Text = "label5";
            this.option5Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // option6Lbl
            // 
            this.option6Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.option6Lbl.AutoSize = true;
            this.option6Lbl.BackColor = System.Drawing.Color.Transparent;
            this.option6Lbl.Font = new System.Drawing.Font("Verdana Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option6Lbl.Location = new System.Drawing.Point(693, 310);
            this.option6Lbl.Name = "option6Lbl";
            this.option6Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.option6Lbl.Size = new System.Drawing.Size(52, 20);
            this.option6Lbl.TabIndex = 11;
            this.option6Lbl.Text = "label6";
            this.option6Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // option1Btn
            // 
            this.option1Btn.BackColor = System.Drawing.Color.Transparent;
            this.option1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option1Btn.Location = new System.Drawing.Point(11, 94);
            this.option1Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option1Btn.Name = "option1Btn";
            this.option1Btn.Size = new System.Drawing.Size(131, 65);
            this.option1Btn.TabIndex = 12;
            this.option1Btn.UseVisualStyleBackColor = false;
            this.option1Btn.Click += new System.EventHandler(this.option1Btn_Click);
            // 
            // option2Btn
            // 
            this.option2Btn.BackColor = System.Drawing.Color.Transparent;
            this.option2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option2Btn.Location = new System.Drawing.Point(11, 190);
            this.option2Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option2Btn.Name = "option2Btn";
            this.option2Btn.Size = new System.Drawing.Size(131, 65);
            this.option2Btn.TabIndex = 13;
            this.option2Btn.UseVisualStyleBackColor = false;
            this.option2Btn.Click += new System.EventHandler(this.option2Btn_Click);
            // 
            // option3Btn
            // 
            this.option3Btn.BackColor = System.Drawing.Color.Transparent;
            this.option3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option3Btn.Location = new System.Drawing.Point(11, 286);
            this.option3Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option3Btn.Name = "option3Btn";
            this.option3Btn.Size = new System.Drawing.Size(131, 65);
            this.option3Btn.TabIndex = 14;
            this.option3Btn.UseVisualStyleBackColor = false;
            this.option3Btn.Click += new System.EventHandler(this.option3Btn_Click_1);
            // 
            // option4Btn
            // 
            this.option4Btn.BackColor = System.Drawing.Color.Transparent;
            this.option4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option4Btn.Location = new System.Drawing.Point(781, 94);
            this.option4Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option4Btn.Name = "option4Btn";
            this.option4Btn.Size = new System.Drawing.Size(131, 65);
            this.option4Btn.TabIndex = 15;
            this.option4Btn.UseVisualStyleBackColor = false;
            this.option4Btn.Click += new System.EventHandler(this.option4Btn_Click_1);
            // 
            // option5Btn
            // 
            this.option5Btn.BackColor = System.Drawing.Color.Transparent;
            this.option5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option5Btn.Location = new System.Drawing.Point(781, 190);
            this.option5Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option5Btn.Name = "option5Btn";
            this.option5Btn.Size = new System.Drawing.Size(131, 65);
            this.option5Btn.TabIndex = 16;
            this.option5Btn.UseVisualStyleBackColor = false;
            this.option5Btn.Click += new System.EventHandler(this.option5Btn_Click_1);
            // 
            // option6Btn
            // 
            this.option6Btn.BackColor = System.Drawing.Color.Transparent;
            this.option6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option6Btn.ForeColor = System.Drawing.Color.Transparent;
            this.option6Btn.Location = new System.Drawing.Point(781, 286);
            this.option6Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.option6Btn.Name = "option6Btn";
            this.option6Btn.Size = new System.Drawing.Size(131, 65);
            this.option6Btn.TabIndex = 17;
            this.option6Btn.UseVisualStyleBackColor = false;
            this.option6Btn.Click += new System.EventHandler(this.option6Btn_Click_1);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ATM.Properties.Resources.backGroundImg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 688);
            this.Controls.Add(this.option6Btn);
            this.Controls.Add(this.option5Btn);
            this.Controls.Add(this.option4Btn);
            this.Controls.Add(this.option3Btn);
            this.Controls.Add(this.option2Btn);
            this.Controls.Add(this.option1Btn);
            this.Controls.Add(this.option6Lbl);
            this.Controls.Add(this.option5Lbl);
            this.Controls.Add(this.option4Lbl);
            this.Controls.Add(this.option3Lbl);
            this.Controls.Add(this.option2Lbl);
            this.Controls.Add(this.option1Lbl);
            this.Controls.Add(this.wrongInputLbl);
            this.Controls.Add(this.keypadPnl);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.instructionsLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.keypadPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Panel keypadPnl;
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
        private System.Windows.Forms.Label option1Lbl;
        private System.Windows.Forms.Label option2Lbl;
        private System.Windows.Forms.Label option3Lbl;
        private System.Windows.Forms.Label option4Lbl;
        private System.Windows.Forms.Label option5Lbl;
        private System.Windows.Forms.Label option6Lbl;
        private System.Windows.Forms.Button option1Btn;
        private System.Windows.Forms.Button option2Btn;
        private System.Windows.Forms.Button option3Btn;
        private System.Windows.Forms.Button option4Btn;
        private System.Windows.Forms.Button option5Btn;
        private System.Windows.Forms.Button option6Btn;
    }
}