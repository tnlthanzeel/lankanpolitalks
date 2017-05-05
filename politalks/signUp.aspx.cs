using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace politalks
{
    public partial class signUp : System.Web.UI.Page
    {
        private string conString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["lpcontext"].ConnectionString;
            try
            {
                if (IsPostBack)
                {
                    //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43PGOJL-NLTHANZEEL;Initial Catalog=lankanpolitalks;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(conString);
                    conn.Open();
                    string checkuser = "select count(*) from login where FirstName='" + txtFname + "'   ";
                    SqlCommand com = new SqlCommand(checkuser, conn);
                    int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                    if (temp == 1)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('User Already Exists.');window.location='signUp.aspx';", true);
                        Response.Write("User already exists");
                    }


                    conn.Close();

                }
            }
            catch
            {
                Response.Write("Error:");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LRBQLGE;Initial Catalog=lankanpolitalks;Integrated Security=True");
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                string inputuser = "insert into login(Fname,Lname,Email,Password) values('" + txtFname.Value + "','" + txtLname.Value + "','" + txtEmail.Value + "','" + txtPassword.Value + "')";
                SqlCommand com = new SqlCommand(inputuser, conn);
                //com.Parameters.AddWithValue("@Fname", txtFname.Value);
                //com.Parameters.AddWithValue("@Lname", txtLname.Value);
                //com.Parameters.AddWithValue("@Email", txtEmail.Value);
                //com.Parameters.AddWithValue("@Password", txtPassword.Value);

                com.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Registration is Success.');window.location='signUp.aspx';", true);
                Response.Redirect("index.html");
                //Response.Write("Registration is success");
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