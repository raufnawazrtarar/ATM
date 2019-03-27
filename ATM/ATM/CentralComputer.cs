/**
 * ATM
 * CentralComputer form
 * 
 * Made by:
 *  Alexander Arnaudov
 *  Rauf Nawaz Tarar Sultana
 *  Archie Rutherford
 *  
 *  Some sections of code were from the
 *  sample code given on my.dundee.ac.uk
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ATM
{
    public partial class CentralComputer : Form
    {
        private static int ATMCount = 0;
        private Account[] ac = new Account[3];

        // Constructor
        public CentralComputer()
        {
            InitializeComponent();

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

        }

        // Create an isntance of ATM with a Semaphore
        public void RunATMwith()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM(ac, true));
        }

        // Create an isnatnce of ATM without a Semaphore
        public void RunATMwithout()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM(ac, false));
        }

        // Create an ATM thread with a Semaphore
        private void openNewATM_Click(object sender, EventArgs e)
        {
            Thread ATM_t = new Thread(RunATMwith);
            ATM_t.Start();
            ATMCount = ATMCount + 1;
            openATMsNumLbl.Text = ATMCount.ToString();
        }

        // Create an ATM thread without any semaphore
        private void openATMwithout_Click(object sender, EventArgs e)
        {
            Thread ATM_t = new Thread(RunATMwithout);
            ATM_t.Start();
            ATMCount = ATMCount + 1;
            openATMsNumLbl.Text = ATMCount.ToString();
        }

        // When the form loads 
        private void CentralComputer_Load(object sender, EventArgs e)
        {

        }
        
        //Cofirmation box before shutting down the system
        private void shutDownBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to shut down the system. This will close all the ATMs and Central computer", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            } 
        }
    }

    public class Account
    {
        // The attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        public Semaphore accessed;

        // A constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            accessed = new Semaphore(1, 1);
        }

        // Getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        // Remove money from the account
        public Boolean decrementBalance(int amount)
        {
            if (this.balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // Checks PIN and returns true if it is correct
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
                return true;
            else
                return false;
        }

        // Return account number
        public int getAccountNum()
        {
            return accountNum;
        }

    }
}
