using System;
using System.Configuration;
using System.Data.SqlClient;


namespace lankapolitalks
{
    public partial class Registration1 : System.Web.UI.Page
    {
        private string conString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["lpcontext"].ConnectionString;
            try
            {
                if (IsPostBack)
                {
                    SqlConnection conn = new SqlConnection(conString);
                    conn.Open();
                    string checkuser = "select count(*) from tbl_userDetails where Fname='" + txtFname + "'   ";
                    SqlCommand com = new SqlCommand(checkuser, conn);
                    int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                    if (temp == 1)
                    {
                        Response.Write("User already exsits");

                    }


                    conn.Close();

                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                string inputuser = "insert into tbl_userDetails(Fname,LName,Email,Password) values('" + txtFname.Value + "','" + txtLname.Value + "','" + txtEmail.Value + "','" + txtPassword.Value + "')";
                SqlCommand com = new SqlCommand(inputuser, conn);
                

                com.ExecuteNonQuery();


                Response.Redirect("index.html");
                Response.Write("Registration is success");
                conn.Close();
            }
            catch (Exception ex)
            {
                // Response.Write("Error:");
                Response.Write(ex.ToString());
            }

        }
    }
}