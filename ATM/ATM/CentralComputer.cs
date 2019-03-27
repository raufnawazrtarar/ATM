﻿using System;
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
        private Account[] ac = new Account[3];

        public CentralComputer()
        {
            InitializeComponent();

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        public void RunATM()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM(ac));
        }

        private void openNewATM_Click(object sender, EventArgs e)
        {
            Thread ATM_t = new Thread(RunATM);
            ATM_t.Start();
        }

        private void CentralComputer_Load(object sender, EventArgs e)
        {

        }

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
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        public Semaphore accessed;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            accessed = new Semaphore(1, 1);
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
                return true;
            else
                return false;
        }

        public int getAccountNum()
        {
            return accountNum;
        }

    }
}
