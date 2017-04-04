using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication5
{
    public partial class registration : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRBQLGE;Initial Catalog=SriLankanPoliTalks;Integrated Security=True");
                conn.Open();
                string checkuser = "select count(*) from login where FirstName='"+txtFname+"'   ";
                SqlCommand com = new SqlCommand(checkuser,conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp==1)
                {
                    Response.Write("User already exsits");

                }

                conn.Close();

            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRBQLGE;Initial Catalog=SriLankanPoliTalks;Integrated Security=True");
            conn.Open();
            string inputuser = "insert into login(FirstName,LastName,Email,Password) values(@Fname,@Lname,@Email,@Password)";
            SqlCommand com = new SqlCommand(inputuser, conn);
                com.Parameters.AddWithValue("@Fname",txtFname.Value);
                com.Parameters.AddWithValue("@Lname", txtLname.Value);
                com.Parameters.AddWithValue("@Email", txtEmail.Value);
                com.Parameters.AddWithValue("@Password", txtPassword.Value);

                com.ExecuteNonQuery();
                Response.Redirect("index.html");
                Response.Write("Registration is success");
                conn.Close();
            }
            catch 
            {
                Response.Write("Error:");
            }
        }
    }
}