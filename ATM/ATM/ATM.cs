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

        public ATM(Account[] ac)
        {
            InitializeComponent();
            this.ac = ac;
            state = 1;
        }

        private void ATM_Load(object sender, EventArgs e)
        {
            display();
        }

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

        //when button "1" is pressed it adds "1" to the textbox
        private void numOneBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "1";
        }

        //when button "2" is pressed it adds "2" to the textbox
        private void numTwoBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length<accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "2";
        }

        //when button "3" is pressed it adds "3" to the textbox
        private void numThreeBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "3";
        }

        //when button "4" is pressed it adds "4" to the textbox
        private void numFourBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "4";
        }

        //when button "5" is pressed it adds "5" to the textbox
        private void numFiveBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "5";
        }

        //when button "6" is pressed it adds "6" to the textbox
        private void numSixBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "6";
        }

        //when button "7" is pressed it adds "7" to the textbox
        private void numSevenBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "7";
        }

        //when button "8" is pressed it adds "8" to the textbox
        private void numEightBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "8";
        }

        //when button "9" is pressed it adds "9" to the textbox
        private void numNineBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "9";
        }

        //when button "0" is pressed it adds "0" to the textbox
        private void numZeroBtn_Click(object sender, EventArgs e)
        {
            if (accountNumTextbox.Text.Length < accountNumTextbox.MaxLength) accountNumTextbox.Text = accountNumTextbox.Text + "0";
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = "";
        }

        private void display()
        {
            if (state == 1) // Account Number State
            {
                instructionsLbl.Text = "Enter Account Number";
                wrongInputLbl.Text = "";
                accountNumTextbox.MaxLength = 6;
            }
            else if (state == 2) // PIN State
            {
                instructionsLbl.Text = "Enter PIN";
                wrongInputLbl.Text = "";
                accountNumTextbox.MaxLength = 4;
            }
            else if (state == 3) // Display Options
            {
                instructionsLbl.Text = "We're In";
                wrongInputLbl.Text = "";

            }
            else if (state == 4) // Get Amount to Withdraw
            {

            }
            else if (state == 5) // Display Balance
            {
                instructionsLbl.Text = "Balance is £" + activeAccount.getBalance();
            }
        } 

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (state == 1) // Account Number State
            {
                activeAccount = findAccount(Int32.Parse(accountNumTextbox.Text));
                accountNumTextbox.Text = "";

                if (activeAccount != null)
                {
                    state = 2;
                    display();
                }
                else
                    wrongInputLbl.Text = "Wrong Account Number";
            }
            else if (state == 2) // PIN State
            {
                if (activeAccount.checkPin(Int32.Parse(accountNumTextbox.Text)))
                {
                    state = 3;
                    display();
                }
                else
                    wrongInputLbl.Text = "Wrong PIN";

                accountNumTextbox.Text = "";

            }
            else if (state == 3) // Display Options
            {
                
            }
            else if (state == 4) // Get Amount to Withdraw
            {

            }
            else if (state == 5) // Display Balance
            {

            }

            //if the pin is wrong then

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = "";
        }
    }
}