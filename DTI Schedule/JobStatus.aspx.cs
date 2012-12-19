using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WorkScheduler
{
    public partial class JobStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string level = (string)(Session["level"]);

                if (String.IsNullOrEmpty(level))
                {
                    Response.Redirect("/Account/Login.aspx");
                }

                if (!level.Equals("SalesRep") && !level.Equals("4"))
                {
                    Response.Redirect("/Account/Login.aspx");
                }

                BindGrid();
            }
        }

        private void BindGrid()
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "SELECT JobNumber FROM JobList";
            SqlCommand cmd = new SqlCommand(sql, conn);


            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    jobListBox.Items.Add(rdr.GetValue(0).ToString());
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        protected void jobListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDetails();
        }

        private void BindDetails()
        {
            int selectedRowIndex = jobListBox.SelectedIndex;
            string jobList =jobListBox.SelectedValue;
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, DeliveryTime, JobType, JobLocation, Shift, Employee FROM JobList WHERE JobNumber=@JobNumber", conn);
            comm.Parameters.Add("@JobNumber", SqlDbType.Int);
            comm.Parameters["@JobNumber"].Value = jobList;

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                jobDetails.DataSource = reader;
                jobDetails.DataKeyNames = new string[] { "JobNumber" };
                jobDetails.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void jobListBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            BindDetails();
        }

        protected void addJobButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SalesRep.aspx");
        }
    }
}
