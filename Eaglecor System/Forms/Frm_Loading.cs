using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Eaglecor_System
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressSpinner.Value += 1;
            if (ProgressSpinner.Value == 10)
            {
                label1.Text = "Loading.";
            }
            if (ProgressSpinner.Value == 20)
            {
                label1.Text = "Loading..";
            }
            if (ProgressSpinner.Value == 30)
            {
                label1.Text = "Loading...";
            }
            if (ProgressSpinner.Value == 40)
            {
                label1.Text = "Loading.";
            }
            if (ProgressSpinner.Value == 50)
            {
                label1.Text = "Loading..";
            }
            if (ProgressSpinner.Value == 60)
            {
                label1.Text = "Loading...";
            }
            if (ProgressSpinner.Value == 70)
            {
                label1.Text = "Loading.";
            }
            if (ProgressSpinner.Value == 80)
            {
                label1.Text = "Loading..";
            }
            if (ProgressSpinner.Value == 90)
            {
                label1.Text = "Loading...";
            }
            if (ProgressSpinner.Value == 100)
            {
                ProgressSpinner.Value = 0;
                timer1.Stop();
                Forms.Frm_Login flogin = new Forms.Frm_Login();
                flogin.Show();
                Hide();
            }
        }

        private void ProgressSpinner_Click(object sender, EventArgs e)
        {

        }
    }
}
