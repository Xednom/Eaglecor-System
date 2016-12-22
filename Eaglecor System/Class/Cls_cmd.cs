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
        //Saving Query Form Facility
        public static void FSave()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string FSave = "Insert Into tblFacilities (Province,Cities,Last_Name,Middle_Name,First_Name,Code,F_Address,Pictures,Activities,Incidents,Inspectors,Site_Owner,Supervisor,DY_SG,Equipments) VALUES (@Province,@Cities,@Lname,@Mname,@Fname,@Code,@Address,@Pictures,@Activities,@Incidents,@Inspectors,@SiteOwner,@Supervisor,@Guard,@Equipments)";

            cmd.Parameters.AddWithValue("@Province", Forms.Frm_PLDT.Province);
            cmd.Parameters.AddWithValue("@Cities", Forms.Frm_PLDT.Cities);
            cmd.Parameters.AddWithValue("@Lname", Forms.Frm_PLDT.Lname);
            cmd.Parameters.AddWithValue("@Mname", Forms.Frm_PLDT.Mname);
            cmd.Parameters.AddWithValue("@Fname", Forms.Frm_PLDT.Fname);
            cmd.Parameters.AddWithValue("@Code", Forms.Frm_PLDT.Code);
            cmd.Parameters.AddWithValue("@Address", Forms.Frm_PLDT.Address);
            cmd.Parameters.AddWithValue("@Pictures", Forms.Frm_PLDT.Pictures);
            cmd.Parameters.AddWithValue("@Activities", Forms.Frm_PLDT.Activities);
            cmd.Parameters.AddWithValue("@Incidents", Forms.Frm_PLDT.Incidents);
            cmd.Parameters.AddWithValue("@Inspectors", Forms.Frm_PLDT.Inspectors);
            cmd.Parameters.AddWithValue("@SiteOwner", Forms.Frm_PLDT.SiteOwner);
            cmd.Parameters.AddWithValue("@Supervisor", Forms.Frm_PLDT.Supervisor);
            cmd.Parameters.AddWithValue("@Guard", Forms.Frm_PLDT.Guard);
            cmd.Parameters.AddWithValue("@Equipments", Forms.Frm_PLDT.Equipments);

            cmd.CommandText = FSave;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();
            
        }

    }
}
