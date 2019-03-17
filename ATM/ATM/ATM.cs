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

        /* Defining all CONSTANTS here */
        //ATM Form
        public const int FORM_SIZE = 700;    //Size of each form axis
        public const int FORM_MARGIN_Y = 20; //Size of top vertical margin 

        //Display Screen
        public const int MAX_ACCOUNT = 6;   //Maximum length of Account Number is 6
        public const int MAX_PIN = 4;       //Maximum length of PIN is 4

        public const int WITHDRAW_1 = 5;    //Amount withdrawn when top left button is clicked
        public const int WITHDRAW_2 = 10;   //Amount withdrawn when bottom left button is clicked
        public const int WITHDRAW_3 = 20;   //Amount withdrawn when top right button is clicked

        //Keypad
        public const int KEYPAD_AXIS = 3;   //Number of Buttons on a single line of the keypad
        public const int KEYPAD_SIZE = 100;  //Size of each keypad button 

        //array of buttons represents the keypad
        Button[] keypad = new Button[(KEYPAD_AXIS * KEYPAD_AXIS) + 1];

        public ATM()
        {
            InitializeComponent();
        }

        private void ATM_Load(object sender, EventArgs e)
        {
            InitializeKeypad();
        }

        /* This funtion customise input keypad (size, location and color) */
        public void InitializeKeypad()
        {

            //keypad array reference
            int counter = 1;

            //create offset to center keypad horizontally
            int offsetX = FORM_SIZE / 2 - ((KEYPAD_AXIS * KEYPAD_SIZE) / 2) - KEYPAD_SIZE / 2;

            //create offset to center keypad vertically 
            int offsetY = FORM_SIZE / 2 - ((KEYPAD_AXIS * KEYPAD_SIZE) / 2) + KEYPAD_SIZE / 2;


            //Create and customise keypad buttons 1 - 9
            for (int i = 0; i < KEYPAD_AXIS; i++)
            {
                for (int j = 0; j < KEYPAD_AXIS; j++)
                {
                    //Assign array value to new button
                    keypad[counter] = new Button();

                    //Set size & location of keypad button
                    keypad[counter].SetBounds(offsetX + (KEYPAD_SIZE * j), offsetY + (KEYPAD_SIZE * i), KEYPAD_SIZE, KEYPAD_SIZE);

                    //Display representative value on keypad button
                    keypad[counter].Text = Convert.ToString(counter);

                    //Change keypad button color
                    keypad[counter].BackColor = Color.Gainsboro;
                    keypad[counter].FlatAppearance.BorderColor = Color.Gainsboro;
                    keypad[counter].Font = new Font("Verdana", 10);



                    //Add keypad button to ATM form 
                    Controls.Add(keypad[counter]);

                    //Increment button number
                    counter++;
                }
            }
        }
    }
}