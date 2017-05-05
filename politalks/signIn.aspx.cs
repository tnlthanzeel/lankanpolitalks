using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace politalks
{
    public partial class signIn : System.Web.UI.Page
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
                //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43PGOJL\TNLTHANZEEL;Integrated Security=true;Initial Catalog=lankanplitalks");
                SqlConnection conn = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                SqlDataAdapter ada = new SqlDataAdapter();
                ada.SelectCommand = cmd;

                conn.Open();

                string em = txtEmail.Value;
                string pwd = txtPassword.Value;


                cmd.CommandText = "select [Password],[Email] from login where [Email] ='" + em + "'";
                DataTable dt = new DataTable();
                ada.Fill(dt);
                string password = dt.Rows[0]["Password"].ToString();
                string email = dt.Rows[0]["Email"].ToString();

                if (pwd.Equals(password))
                {
                    Session["email"] = email;
                    Response.Redirect("Politicians.html");
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
