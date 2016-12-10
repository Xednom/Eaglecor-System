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
using System.Data.SqlClient;
using System.Configuration;
using Eaglecor_System.Class;

namespace Eaglecor_System.Forms
{
    public partial class Frm_Login : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public static string UserTypeParam = "";
        public static string UserType = "";
        public static string Username = "";
        public static string Password = "";
        public Frm_Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadUserype()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblAccount";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gCategory = reader.GetString(reader.GetOrdinal("Account"));
                cBoxUsertype.Items.Add(gCategory);
            }
            conn.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            loadUserype();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Frm_Main fmain = new Forms.Frm_Main();
            fmain.Show();
            Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Username = txt_un.Text;
            //Password = txt_pw.Text;
            //UserType = cBoxUsertype.Text;
            //UserTypeParam = cBoxUsertype.Text;
            //Class.Cls_cmd.Login();
            Frm_Main fmain = new Frm_Main();
            fmain.Show();
            Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
