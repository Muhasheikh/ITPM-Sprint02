using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTableManagement
{
    public partial class lecturerTime : UserControl
    {
        public lecturerTime()
        {
            InitializeComponent();
        }

        private void cmbSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* Making the connection with the SQL server*/

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EIA1KI\SQLEXPRESS;Initial Catalog=TimeTableManagement;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        int Record_ID;


     

        public static DataTable DataSource { get; private set; }
        public static string ValueMember { get; private set; }
        public static string DisplayMember { get; private set; }


        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            adpt = new SqlDataAdapter("select * from Consecutive_Management", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSearchL.DataSource = dt;
        }
    }
}
