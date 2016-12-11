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

namespace Eaglecor_System.Forms
{
    public partial class Frm_Facilities : MetroForm
    {
        public Frm_Facilities()
        {
            InitializeComponent();
        }

        private void Frm_Facilities_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Frm_PLDT fpldt = new Frm_PLDT();
            fpldt.ShowDialog();
        }
    }
}
