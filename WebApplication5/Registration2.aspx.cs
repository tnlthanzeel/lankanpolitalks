using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace lankapolitalks
{
    public partial class Registration2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LRBQLGE;Initial Catalog=lankanpolitalks;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                SqlDataAdapter ada = new SqlDataAdapter() ;
                ada.SelectCommand = cmd;

                conn.Open();

                string em = txtEmail.Value;
                string pwd = txtPassword.Value;


                cmd.CommandText = @"select [Password] from login where [Email] ='"+em+"'";
                DataTable dt = new DataTable();
                ada.Fill(dt);
                string password = dt.Rows[0]["Password"].ToString();

                if ( pwd.Equals(password))
                {
                    Response.Redirect("index.html");
                }
                else

                {
                    
                    Response.Write("");
                
                }

                //cmd.ExecuteNonQuery();
                //Response.Redirect("index.html");
                //Response.Write("Registration is success");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}