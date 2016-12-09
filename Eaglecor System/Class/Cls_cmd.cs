using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using System.Configuration;

namespace Eaglecor_System.Class
{
    class Cls_cmd
    {
        public static void Login()
        {
            Forms.Frm_Login _owner = new Forms.Frm_Login();

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT A.Account, L.UN, L.PW FROM tblUser AS U LEFT JOIN tblAccount AS A ON A.AcctID = U.AcctID LEFT JOIN tblLogin AS L ON L.AcctID = U.AcctID WHERE L.UN = @un AND L.PW = @pw AND A.Account = @ut";
            cmd.Parameters.AddWithValue("un", Forms.Frm_Login.Username);
            cmd.Parameters.AddWithValue("pw", Forms.Frm_Login.Password);
            cmd.Parameters.AddWithValue("ut", Forms.Frm_Login.UserType);
            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show(_owner, "Welcome!", "EAGLECOR System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Forms.Frm_Login.UserType = Forms.Frm_Login.UserTypeParam;
                Forms.Frm_Main fmain = new Forms.Frm_Main();
                fmain.Show();
                
            }
            else
            {
                MessageBox.Show(_owner, "Wrong username or password!", "EAGLECOR System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            conn.Close();
            cmd.Parameters.Clear();
        }
    }
}
