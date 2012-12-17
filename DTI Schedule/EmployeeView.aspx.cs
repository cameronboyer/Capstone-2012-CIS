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
    public partial class EmployeeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 

                //String.IsNullOrEmpty((string)(Session["level"]));
                string level = (string)(Session["level"]);
                if (String.IsNullOrEmpty(level))
                {
                    Response.Redirect("/Account/Login.aspx");
                }
                if (!level.Equals("Employee") && !level.Equals("4"))
                {
                    Response.Redirect("/Account/Login.aspx");
                }


                BindGrid();
                buildShift2List();
                buildShift3List();
            }
        }

        private void BindGrid()
        {
            string connString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "SELECT JobNumber FROM JobList WHERE Shift = CAST(1 AS VARCHAR(1))";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    shift1ListBox.Items.Add(rdr.GetValue(0).ToString());
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

        public void buildShift2List()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT JobNumber FROM JobList WHERE Shift = CAST(2 AS VARCHAR(1))", con);
                SqlDataReader reader = cmd.ExecuteReader();
                shift2ListBox.DataSource = reader;
                shift2ListBox.DataTextField = "JobNumber";
                shift2ListBox.DataBind();
            }
        }

        public void buildShift3List()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT JobNumber FROM JobList WHERE Shift = CAST(3 AS VARCHAR(1))", con);
                SqlDataReader reader = cmd.ExecuteReader();
                shift3ListBox.DataSource = reader;
                shift3ListBox.DataTextField = "JobNumber";
                shift3ListBox.DataBind();
            }
        }

        protected void shift1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = shift1ListBox.SelectedIndex;
            string chucksDB = shift1ListBox.SelectedValue;
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, JobType, JobLocation, Employee FROM JobList WHERE JobNumber=@JobNumber", conn);
            comm.Parameters.Add("@JobNumber", SqlDbType.Int);
            comm.Parameters["@JobNumber"].Value = chucksDB;
            shift2ListBox.SelectedIndex = -1;
            shift3ListBox.SelectedIndex = -1;
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

        protected void shift2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = shift2ListBox.SelectedIndex;
            string chucksDB = shift2ListBox.SelectedValue;
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, JobType, JobLocation, Employee FROM JobList WHERE JobNumber=@JobNumber", conn);
            comm.Parameters.Add("@JobNumber", SqlDbType.Int);
            comm.Parameters["@JobNumber"].Value = chucksDB;
            shift1ListBox.SelectedIndex = -1;
            shift3ListBox.SelectedIndex = -1;

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

        protected void shift3ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = shift3ListBox.SelectedIndex;
            string chucksDB = shift3ListBox.SelectedValue;
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["chucksDB"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, JobType, JobLocation, Employee FROM JobList WHERE JobNumber=@JobNumber", conn);
            comm.Parameters.Add("@JobNumber", SqlDbType.Int);
            comm.Parameters["@JobNumber"].Value = chucksDB;
            shift1ListBox.SelectedIndex = -1;
            shift2ListBox.SelectedIndex = -1;

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
    }
}