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
        public ATM()
        {
            InitializeComponent();
        }

        private void ATM_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        //when button "1" is pressed it adds "1" to the textbox
        private void numOneBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "1";
        }

        //when button "2" is pressed it adds "2" to the textbox
        private void numTwoBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "2";
        }

        //when button "3" is pressed it adds "3" to the textbox
        private void numThreeBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "3";
        }

        //when button "4" is pressed it adds "4" to the textbox
        private void numFourBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "4";
        }

        //when button "5" is pressed it adds "5" to the textbox
        private void numFiveBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "5";
        }

        //when button "6" is pressed it adds "6" to the textbox
        private void numSixBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "6";
        }

        //when button "7" is pressed it adds "7" to the textbox
        private void numSevenBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "7";
        }

        //when button "8" is pressed it adds "8" to the textbox
        private void numEightBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "8";
        }

        //when button "9" is pressed it adds "9" to the textbox
        private void numNineBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "9";
        }

        //when button "0" is pressed it adds "0" to the textbox
        private void numZeroBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = accountNumTextbox.Text + "0";
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = "";
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = "";
            //if account number matches the records then
            label1.Visible = false;
            label3.Visible = true;
              //if the pin is wrong then 
              label4.Visible = true;

            //if the account number is wrong then
            label2.Visible = true;
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            accountNumTextbox.Text = "";
        }
    }
}