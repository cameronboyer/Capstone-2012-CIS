﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace DTI_Schedule.Account
{
    public partial class Login : System.Web.UI.Page
    {
        string CS = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string loginName = txtUsername.Text.Trim();
            //no encryption ... who cares...
            string password = txtPassword.Text.Trim();

            string queryLevel = "SELECT level FROM Users WHERE userName = @userName and password = @password";

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(queryLevel, con))
                {
                    com.Parameters.AddWithValue("@userName", loginName);
                    com.Parameters.AddWithValue("@password", password);

                    //sets the users level, returns null if incorrect info
                    Session["level"] = com.ExecuteScalar();

                    //the as prevents errors
                    string level = Session["level"] as string;

                    if (String.IsNullOrEmpty(level))
                    {
                        //redirectes on error
                        Response.Redirect("ERRORPAGE");
                    }
                    else
                    {   //looks at level and directs accordingly, The redirects need to be actual pages
                        //Pages also need to be checking session level for the appropriate rights.
                        switch (level)
                        {
                            case "Employee":
                                Response.Redirect("EMPLOYEEPAGE");
                                break;
                            case "Scheduler":
                                Response.Redirect("SCHEDULE");
                                break;
                            case "Sales":
                                Response.Redirect("SALES");
                                break;
                        }

                    }

                }
               

            }
        }
    }
}
