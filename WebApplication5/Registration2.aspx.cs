using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace lankapolitalks
{
    public partial class Registration2 : System.Web.UI.Page
    {
        private string conString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["lpcontext"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                SqlDataAdapter ada = new SqlDataAdapter();
                ada.SelectCommand = cmd;

                conn.Open();

                String em = txtEmail.Value;
                String pwd = txtPassword.Value;


                cmd.CommandText = @"select [Password] from login where [Email] ='" + em + "'";
                DataTable dt = new DataTable();
                ada.Fill(dt);
                string password = dt.Rows[0]["Password"].ToString();

                if (pwd.Equals(password))
                {
                    Response.Redirect("index.html");
                }
                else

                {

                    Response.Write("");

                }


                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}