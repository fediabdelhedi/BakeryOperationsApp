using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 3000; // 3000 milliseconds = 3 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer to prevent further ticks
            timer1.Stop();

            Login form1 = new Login();
            form1.FormClosed += (s, eventArgs) => this.Close(); // Show the first form when the second form is closed
            this.Hide(); // Hide the first form
            form1.ShowDialog(); // Show the second form
        }
    }
}
