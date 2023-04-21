using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.CodeDom;
using System.Web;
using System.Xml.Linq;

namespace Vixen_Editor
{
    public partial class Form1 : Form
    {
        static string samsConnect = @"Data Source=192.168.127.12\SAMS;Initial Catalog=SAMSData;User ID=sa;Password=b41f4e67!";
        static string vixConnect = @"Data Source=192.168.127.12\CAUSEWAY;Initial Catalog=vixen_live;User ID=vixenuser;Password=vixenuser";
        static string orderGrab = $"SELECT CUSTOMER_ORDER_NUMBER FROM JOBCOSTING_JOBS WHERE JOB_NUMBER = @jNum AND SUB_JOB_NUMBER = @sjNum";
        static string jobGrab = $"SELECT JOB_NUMBER, SUB_JOB_NUMBER FROM JOBCOSTING_JOBS WHERE CUSTOMER_ORDER_NUMBER = @oNum";
        static string dateGrab = $"SELECT DATE_FINISHED FROM SERVICERECORDS_CALL_OUTS WHERE JOB_NUMBER = @jNum and SUB_JOB_NUMBER = @sjNum";
        static string comGrab = $"SELECT CONCAT(DESCRIPTION_02, DESCRIPTION_03, DESCRIPTION_04, DESCRIPTION_05) AS COMMENT FROM SERVICERECORDS_COMPLETION_TEXT WHERE DESCRIPTION_04 <> ' ' AND _vix_KEY_SUB_VISIT = @sjNum";
        static string test = "This is a test.";
        public Form1()
        {
            InitializeComponent();
        }
        public static void populateEntries()
        {

        }

        /* - COMMENTS -
         * 
         * Table Name = SERVICE_RECORDS_COMPLETEION_TEXT
         * Field = DESCRIPTION_04
         * 
         * - DATE CHANGE - 
         * 
         * Table Name = SERVICERECORDS_CALL_OUTS
         * Field = DATE_FINISHED
         * 
         */

        /* 
         * 1. Declare connection string
         * 2. Declare command string
         * 3. Establish connection to the vixen DB
         * 4. Pass new modified variables 
         * 4a. Assure changes have been made#
         * 5. Close connection
         * 6. Re-enable Job Number boxes and order boxes
         */
        public static void openConnection()
        {
            /* 
             * SAMserver = '192.168.127.12\SAMS'
             * SAMdatabase = 'SAMSData'
             * SAMusername = 'sa'
             * SAMpassword = 'b41f4e67!'
             * string samsConnect = @"Data Source=192.168.127.12\SAMS;Initial Catalog=SAMSData;User ID=sa;Password=b41f4e67!";
             * string vixConnect = @"Data Source=192.168.127.12\CAUSEWAY;Initial Catalog=vixen_live;User ID=vixenuser;Password=vixenuser";
             */

            try
            {
                using (SqlConnection vixCon = new SqlConnection(vixConnect))
                {
                    vixCon.Open();
                    Console.WriteLine("Connection String: {0}", vixCon.ConnectionString);
                    Console.WriteLine("State: {0}\n", vixCon.State);

                }
                using (SqlConnection samsCon = new SqlConnection(samsConnect))
                {
                    samsCon.Open();
                    Console.WriteLine("Connection String: {0}", samsCon.ConnectionString);
                    Console.WriteLine("State: {0}", samsCon.State);
                    Console.WriteLine("------------------------------------------");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Unable to establish connection to both databases.", "Database Connection Error");
            }
        }
        public static void closeConnection()
        {
            try
            {
                using (SqlConnection vixCon = new SqlConnection (vixConnect))
                {
                    vixCon.Close();
                    Console.WriteLine("Connnection String: {0}", vixCon.ConnectionString);
                    Console.WriteLine("State: {0}\n", vixCon.State);
                } 
                using (SqlConnection samsCon = new SqlConnection(samsConnect))
                {
                    samsCon.Close();
                    Console.WriteLine("Connection String: {0}", samsCon.ConnectionString);
                    Console.WriteLine("State: {0}", samsCon.State);
                    Console.WriteLine("---------------------------------------------------");
                }
            } catch (System.Exception)
            {
                Console.WriteLine("Error.", "Error");
                MessageBox.Show("Error closing connection to databases.\nContact IT technician.", "Connection Termination Error");
            }
        }
        public void updateCommand(string newComment, string newDate, string orderNum)
        {
            try
            {

            }
            catch (System.Exception)
            {

            }
            Console.WriteLine("New comment = {0}\n" +
                "New date = {1}\n" +
                "New order number = {2}\n" +
                "", newComment, newDate, orderNum);
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int sjNum = Convert.ToInt32(subJobNum.Text);
                string jNum = jobNum.Text;
                string oNum = orderNum.Text;
                openConnection();
                pullData(sjNum, jNum, oNum);
                closeConnection();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a valid Job or Sub Job number.", "Job Number Error");
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            updateCommand(RTBComments.Text, dateComp.Text, orderNum.Text);
        }
        public void pullData(int sjNum, string jNum, string oNum)
        {
            if (jobNum.Text == "" && subJobNum.Text == "")
            {
                using (SqlConnection vixCon = new SqlConnection(vixConnect))
                {
                    using (SqlCommand cmd = new SqlCommand(jobGrab, vixCon))
                    {
                        
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@oNum", orderNum.Text);
                        cmd.Parameters.AddWithValue("@jNum", jNum);
                        cmd.Parameters.AddWithValue("@sjNum", subJobNum.Text);
                        vixCon.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {

                                Console.WriteLine("Data found = {0}", rdr["JOB_NUMBER"].ToString());
                                jobNum.Text = rdr["JOB_NUMBER"].ToString();
                                subJobNum.Text = rdr["SUB_JOB_NUMBER"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
                            }
                        }
                    }
                }
            } else
            {
                
                using (SqlConnection vixCon = new SqlConnection(vixConnect))
                {
                    using (SqlCommand cmd = new SqlCommand(orderGrab, vixCon))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@orderNum", orderNum.Text);
                        cmd.Parameters.AddWithValue("@jNum", jNum);
                        cmd.Parameters.AddWithValue("@sjNum", subJobNum.Text);
                        vixCon.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                Console.WriteLine("Data found = {0}", rdr["CUSTOMER_ORDER_NUMBER"].ToString());
                                orderNum.Text = rdr["CUSTOMER_ORDER_NUMBER"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
                            }
                        }
                    }
                }
            }
        }
        private void clearBTN_Click(object sender, EventArgs e)
        {
            closeConnection();
        }
    }
}
