﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace project2021.zpages
{
    public partial class TeacherMsgPage : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Users.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "Insert into [StudentsMsg](Messages,msgnum) values('" + TextBox.Text + "','" + msgnm.Text + "' )";
            SqlCommand comm = new SqlCommand(ins, con);
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            msg.ForeColor = System.Drawing.Color.Green;
            msg.Text = "Message has been send successfully ";
        }


    }
}