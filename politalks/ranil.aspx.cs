﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace politalks
{
    public partial class ranil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillData();
            }
        }
        private void fillData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LRBQLGE;Initial Catalog=lankanpolitalks;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from tbl_Comment3 Order by Id Desc", con);
            adapt.Fill(dt);
            con.Close();
            PagedDataSource pds = new PagedDataSource();
            DataView dv = new DataView(dt);
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = PageNumber;
            if (pds.PageCount > 1)
            {
                rptPaging.Visible = true;
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < pds.PageCount; i++)
                    arraylist.Add((i + 1).ToString());
                rptPaging.DataSource = arraylist;
                rptPaging.DataBind();
            }
            else
            {
                rptPaging.Visible = false;
            }
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            string email = (string)(Session["email"]);

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LRBQLGE;Initial Catalog=lankanpolitalks;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = cmd;

            con.Open();


            cmd.CommandText = "select [Fname] from login where [Email] ='" + email + "'";
            DataTable dt = new DataTable();
            ada.Fill(dt);
            string Fname = dt.Rows[0]["Fname"].ToString();


            cmd.CommandText = "insert into tbl_Comment3(Name,Email,Comment) values(@name,@email,@comment)";
            cmd.Parameters.AddWithValue("@name", Fname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@comment", txtComment.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            //Displaying Javascript alert Comment Posted Successfully
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Comment Posted Successfully.');window.location='ranil.aspx';", true);
            fillData();
            txtComment.Text = "";

        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }
        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            fillData();
        }
    }
}