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
    public partial class JobSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                buildShiftList();
            }
        }

        private void BindGrid()
        {
            unschedJobListBox.Items.Clear();
            string connString = ConfigurationManager.ConnectionStrings["JobList"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string sql = "SELECT JobNumber FROM JobList WHERE JobStatus = 'Unscheduled'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    unschedJobListBox.Items.Add(rdr.GetValue(0).ToString());
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

        protected void unschedJobListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDetails();
            shiftRBL1.Visible = false;
            selectShiftLabel.Visible = false;
            
        }

        private void BindDetails()
        {
            int selectedRowIndex = unschedJobListBox.SelectedIndex;
            string jobList = unschedJobListBox.SelectedValue;
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["JobList"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, JobType, JobLocation, JobStatus, Shift FROM JobList WHERE JobNumber=@JobNumber", conn);
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

        //binds the Open job number + the shift to the list box
        public void buildShiftList()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["JobList"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT JobNumber, CAST(JobNumber AS VARCHAR(50)) + ', Shift ' + CAST(Shift AS VARCHAR) AS LIST FROM JobList WHERE JobStatus = 'Open'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                openJobsListBox.DataSource = reader;
                openJobsListBox.DataTextField = "LIST";
                openJobsListBox.DataValueField = "JobNumber";
                openJobsListBox.DataBind();
            }
        }

        protected void jobDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftRBL1.Visible = true;
            selectShiftLabel.Visible = true;
        }

        protected void openJobsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = openJobsListBox.SelectedIndex;
            int jobList = Convert.ToInt32(openJobsListBox.SelectedValue);
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["JobList"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT JobNumber, Client, DeliveryTime, JobType, JobLocation, JobStatus, Shift, Employee FROM JobList WHERE JobNumber=@JobNumber", conn);
            //comm.Parameters.Add("@JobNumber", SqlDbType.Int);
            //comm.Parameters["@JobNumber"].Value = jobList;

            comm.Parameters.AddWithValue("@JobNumber", jobList);

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                openJobsDetails.DataSource = reader;
                openJobsDetails.DataKeyNames = new string[] { "JobNumber" };
                openJobsDetails.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void openJobsDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            shiftRBL2.Visible = true;
            shiftLabel.Visible = true;
        }

        protected void shiftRBL2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int jobNumber = Convert.ToInt32(openJobsListBox.SelectedValue); 

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["JobList"].ConnectionString))
            {
                con.Open();
                SqlCommand comm;
               
                comm = new SqlCommand("sp_UpdateJob", con);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.Add("@JobNumber", SqlDbType.Int);
                comm.Parameters["@JobNumber"].Value = jobNumber;
                comm.Parameters.Add("@NewShift", SqlDbType.Int);
                comm.Parameters["@NewShift"].Value = shiftRBL2.SelectedValue;

                comm.ExecuteNonQuery();
            }
            buildShiftList();

            shiftLabel.Visible = false;
            shiftRBL2.Visible = false;
            openJobsDetails.Visible = false;
            openJobsListBox.SelectedIndex = -1;
        }

        protected void shiftRBL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int jobNumber = Convert.ToInt32(unschedJobListBox.SelectedValue); 

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["JobList"].ConnectionString))
            {
                con.Open();
                SqlCommand comm;
               
                comm = new SqlCommand("sp_ScheduleJob", con);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.Add("@JobNumber", SqlDbType.Int);
                comm.Parameters["@JobNumber"].Value = jobNumber;
                comm.Parameters.Add("@Shift", SqlDbType.Int);
                comm.Parameters["@Shift"].Value = shiftRBL1.SelectedValue;

                comm.ExecuteNonQuery();
            }
            buildShiftList();
            BindGrid();

            unschedJobListBox.SelectedIndex = -1;
            jobDetails.Visible = false;
            selectShiftLabel.Visible = false;
            shiftRBL1.Visible = false;
        }
    }
}
