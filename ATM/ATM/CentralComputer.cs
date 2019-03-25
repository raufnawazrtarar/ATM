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
        public CentralComputer()
        {
            InitializeComponent();
        }

        public void RunATM()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM());
        }

        private void openNewATM_Click(object sender, EventArgs e)
        {
            Thread ATM_t = new Thread(RunATM);
            ATM_t.Start();
            
        }
    }
}
