using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATM : Form
    {
        private Account[] ac;
        private Account activeAccount;
        private int state;

        // Constructor for ATM
        public ATM(Account[] ac)
        {
            InitializeComponent();
            this.ac = ac;
            state = 1;
        }

        // Function upon loading form
        private void ATM_Load(object sender, EventArgs e)
        {
            display();
        }

        // Return the account with the corresponding account number
        private Account findAccount(int accountNumber)
        {
            for (int i = 0; i < ac.Length; i++)
            {
                if (ac[i].getAccountNum() == accountNumber)
                {
                    return ac[i];
                }
            }
            return null;
        }

        // Display to the screen depending on the system state
        private void display()
        {
            if (state == 1) // Account Number State
            {
                instructionsLbl.Text = "Enter Account Number";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "";
                option2Lbl.Text = "";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "";
                loginTextbox.Visible = true;
                loginTextbox.MaxLength = 6;
            }
            else if (state == 2) // PIN State
            {
                instructionsLbl.Text = "Enter PIN";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "";
                option2Lbl.Text = "";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "";
                loginTextbox.MaxLength = 4;
                loginTextbox.Visible = true;
            }
            else if (state == 3) // Display Options
            {
                instructionsLbl.Text = "Options";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "Withdraw Cash";
                option2Lbl.Text = "Display Balance";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "";
                loginTextbox.Visible = false;

            }
            else if (state == 4) // Get Amount to Withdraw
            {
                instructionsLbl.Text = "Choose Amount to Withdraw";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "£10";
                option2Lbl.Text = "£20";
                option3Lbl.Text = "£50";
                option4Lbl.Text = "£100";
                option5Lbl.Text = "£200";
                option6Lbl.Text = "Other";
                loginTextbox.Visible = false;
            }
            else if (state == 5) // Display Balance
            {
                activeAccount.accessed.WaitOne();
                instructionsLbl.Text = "Balance is £" + activeAccount.getBalance();
                activeAccount.accessed.Release();
                wrongInputLbl.Text = "";
                option1Lbl.Text = "";
                option2Lbl.Text = "";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "Press to\n Continue";
                loginTextbox.Visible = false;
            }
            else if (state == 6) // Choose Amount State
            {
                instructionsLbl.Text = "Choose Amount to Withdraw";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "";
                option2Lbl.Text = "";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "";
                loginTextbox.Visible = true;
            }
            else if (state == 7) // Display Balance
            {
                instructionsLbl.Text = "Insufficiant Funds";
                wrongInputLbl.Text = "";
                option1Lbl.Text = "";
                option2Lbl.Text = "";
                option3Lbl.Text = "";
                option4Lbl.Text = "";
                option5Lbl.Text = "";
                option6Lbl.Text = "Press to\n continue";
                loginTextbox.Visible = false;
            }
        }

        // When green enter button is pressed
        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "")
            {
                wrongInputLbl.Text = "Ivalid input, Please try again";
            }
            else if (state == 1) // Account Number State
            {
                activeAccount = findAccount(Int32.Parse(loginTextbox.Text));
                loginTextbox.Text = "";

                if (activeAccount != null) // If account number successful
                {
                    state = 2; // PIN State
                    display();
                }
                else
                {
                    wrongInputLbl.Text = "Wrong Account Number";
                }
            }
            else if (state == 2) // PIN State
            {
                if (activeAccount.checkPin(Int32.Parse(loginTextbox.Text))) // If PIN correct
                {
                    state = 3; // Main Menu State
                    display();
                }
                else
                {
                    wrongInputLbl.Text = "Wrong PIN";
                }
                loginTextbox.Text = "";
            }
            else if (state == 6) // Choose Amount State
            {
                activeAccount.accessed.WaitOne();
                if (activeAccount.decrementBalance(Int32.Parse(loginTextbox.Text)))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
                loginTextbox.Text = "";
            }
        } 

        // When yellow clear button is pressed
        private void clearBtn_Click(object sender, EventArgs e)
        {
            loginTextbox.Text = "";
        }

        // When cancel button is pressed
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            state = 1;
            display();
            loginTextbox.Text = "";
            activeAccount = null;
        }

        // When option 1 button is pressed
        private void option1Btn_Click(object sender, EventArgs e)
        {
            if (state == 3)
            {
                state = 4;
                display();
            }
            else if (state == 4)
            {
                activeAccount.accessed.WaitOne();
                if (activeAccount.decrementBalance(10))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
            }
        }

        // When option 2 button is pressed
        private void option2Btn_Click(object sender, EventArgs e)
        {
            if (state == 3)
            {
                state = 5;
                display();
            }
            else if (state == 4)
            {
                activeAccount.accessed.WaitOne();

                if (activeAccount.decrementBalance(20))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
            }
        }

        // When option 3 button is pressed
        private void option3Btn_Click_1(object sender, EventArgs e)
        {
            if (state == 4)
            {
                activeAccount.accessed.WaitOne();
                if (activeAccount.decrementBalance(50))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
            }
        }
        
        // When option 4 button is pressed
        private void option4Btn_Click_1(object sender, EventArgs e)
        {
            if (state == 4)
            {
                activeAccount.accessed.WaitOne();
                if (activeAccount.decrementBalance(100))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
            }
        }

        // When option 5 button is pressed
        private void option5Btn_Click_1(object sender, EventArgs e)
        {
            if (state == 4)
            {
                activeAccount.accessed.WaitOne();
                if (activeAccount.decrementBalance(200))
                    state = 5;
                else
                    state = 7;

                activeAccount.accessed.Release();
                display();
            }
        }

        // When option 6 button is pressed
        private void option6Btn_Click_1(object sender, EventArgs e)
        {
            if (state == 4)
            {
                state = 6;
                display();
            }
            else if (state == 5 || state == 7)
            {
                state = 3;
                display();
            }
        }

        //when button "1" is pressed it adds "1" to the textbox
        private void numOneBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "1";
        }

        //when button "2" is pressed it adds "2" to the textbox
        private void numTwoBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "2";
        }

        //when button "3" is pressed it adds "3" to the textbox
        private void numThreeBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "3";
        }

        //when button "4" is pressed it adds "4" to the textbox
        private void numFourBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "4";
        }

        //when button "5" is pressed it adds "5" to the textbox
        private void numFiveBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "5";
        }

        //when button "6" is pressed it adds "6" to the textbox
        private void numSixBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "6";
        }

        //when button "7" is pressed it adds "7" to the textbox
        private void numSevenBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "7";
        }

        //when button "8" is pressed it adds "8" to the textbox
        private void numEightBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "8";
        }

        //when button "9" is pressed it adds "9" to the textbox
        private void numNineBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "9";
        }
        
        //when button "0" is pressed it adds "0" to the textbox
        private void numZeroBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text.Length < loginTextbox.MaxLength) loginTextbox.Text = loginTextbox.Text + "0";
        }
    }
}