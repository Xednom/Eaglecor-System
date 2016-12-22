using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Eaglecor_System.Forms
{
    public partial class Frm_PLDT : MetroForm
    {
        public static string Province = "";
        public static string Cities = "";
        public static string Lname = "";
        public static string Mname = "";
        public static string Fname = "";
        public static string Code = "";
        public static string Address = "";
        public static string Pictures = "";
        public static string Activities = "";
        public static string Incidents = "";
        public static string Inspectors = "";
        public static string SiteOwner = "";
        public static string Supervisor = "";
        public static string Guard = "";
        public static string Equipments = "";

        public Frm_PLDT()
        {
            InitializeComponent();
        }

        private void Frm_PLDT_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProvince.Text.Equals("Cavite"))
            {
                cBoxCities.Items.Clear();
                cBoxCities.Items.Add("Alfonso");
                cBoxCities.Items.Add("Amadeo");
                cBoxCities.Items.Add("Bacoor");
                cBoxCities.Items.Add("Carmona");
                cBoxCities.Items.Add("Cavite City");
                cBoxCities.Items.Add("Dasmariñas");
                cBoxCities.Items.Add("Gen. Mariano Alvarez");
                cBoxCities.Items.Add("Gen. Emilio Aguinaldo");
                cBoxCities.Items.Add("Gen. Trias");
                cBoxCities.Items.Add("Imus");
                cBoxCities.Items.Add("Indang");
                cBoxCities.Items.Add("Kawit");
                cBoxCities.Items.Add("Magallanes");
                cBoxCities.Items.Add("Maragondon");
                cBoxCities.Items.Add("Mendez");
                cBoxCities.Items.Add("Naic");
                cBoxCities.Items.Add("Noveleta");
                cBoxCities.Items.Add("Rosario");
                cBoxCities.Items.Add("Silang");
                cBoxCities.Items.Add("Tagaytay City");
                cBoxCities.Items.Add("Tanza");
                cBoxCities.Items.Add("Ternate");
                cBoxCities.Items.Add("Trece Martires City");
            }
            if (cBoxProvince.Text.Equals("Laguna"))
            {
                cBoxCities.Items.Clear();
                cBoxCities.Items.Add("Alaminos");
                cBoxCities.Items.Add("Bay");
                cBoxCities.Items.Add("Biñan");
                cBoxCities.Items.Add("Calauan");
                cBoxCities.Items.Add("Cavinti");
                cBoxCities.Items.Add("Famy");
                cBoxCities.Items.Add("Kalayaan");
                cBoxCities.Items.Add("Liliw");
                cBoxCities.Items.Add("Los Baños");
                cBoxCities.Items.Add("Luisiana");
                cBoxCities.Items.Add("Lumban");
                cBoxCities.Items.Add("Mabitac");
                cBoxCities.Items.Add("Magdalena");
                cBoxCities.Items.Add("Majayjay");
                cBoxCities.Items.Add("Nagcarlan");
                cBoxCities.Items.Add("Pagsanjan");
                cBoxCities.Items.Add("Pakil");
                cBoxCities.Items.Add("Pangil");
                cBoxCities.Items.Add("Pila");
                cBoxCities.Items.Add("Rizal");
                cBoxCities.Items.Add("San Pablo City");
                cBoxCities.Items.Add("San Pedro City");
                cBoxCities.Items.Add("Santa Cruz");
                cBoxCities.Items.Add("Santa Maria");
                cBoxCities.Items.Add("Siniloan");
                cBoxCities.Items.Add("Victoria");
            }
            if (cBoxProvince.Text.Equals("Marinduque"))
            {
                cBoxCities.Items.Clear();
                cBoxCities.Items.Add("Boac");
                cBoxCities.Items.Add("Buenavista");
                cBoxCities.Items.Add("Gasan");
                cBoxCities.Items.Add("Mogpog");
                cBoxCities.Items.Add("Santa Cruz");
                cBoxCities.Items.Add("Tormijos");
            }
            if (cBoxProvince.Text.Equals("Palawan"))
            {
                cBoxCities.Items.Clear();
                cBoxCities.Items.Add("Aborlan");
                cBoxCities.Items.Add("Agutaya");
                cBoxCities.Items.Add("Araceli");
                cBoxCities.Items.Add("Balabac");
                cBoxCities.Items.Add("Bataraza");
                cBoxCities.Items.Add("Brooke's Point");
                cBoxCities.Items.Add("Busuanga");
                cBoxCities.Items.Add("Cagayancillio");
                cBoxCities.Items.Add("Coron");
                cBoxCities.Items.Add("Culion");
                cBoxCities.Items.Add("Cuyo");
                cBoxCities.Items.Add("Dumaran");
                cBoxCities.Items.Add("El Nido");
                cBoxCities.Items.Add("Kalayaan");
                cBoxCities.Items.Add("Linapacan");
                cBoxCities.Items.Add("Magsaysay");
                cBoxCities.Items.Add("Narra");
                cBoxCities.Items.Add("Puerto Princesa");

            }
            if (cBoxProvince.Text.Equals(""))
            {
                cBoxCities.Items.Clear();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Save this information?", "EAGLECOR SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Province = cBoxProvince.Text;
                Cities = cBoxCities.Text;
                Lname = tBoxLast.Text;
                Mname = tBoxMiddle.Text;
                Fname = tBoxFirst.Text;
                Code = tBoxCode.Text;
                Address = tBoxAddress.Text;
                Pictures = tBoxPictures.Text;
                Activities = tBoxActivities.Text;
                Incidents = tBoxIncidents.Text;
                Inspectors = tBoxInspections.Text;
                SiteOwner = tBoxSiteOwner.Text;
                Supervisor = tBoxSupervisor.Text;
                Guard = tBoxDYGuard.Text;
                Equipments = tBoxEquipments.Text;
                Class.Cls_cmd.FSave();
                MessageBox.Show("Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO:NOTHING
            }
        }
    }
}
