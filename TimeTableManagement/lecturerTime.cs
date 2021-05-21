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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EIA1KI\SQLEXPRESS;Initial Catalog=TimeTableManagement;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        public lecturerTime()
        {
            InitializeComponent();
            displayLecturer();
        }

        public void displayLecturer()
        {

            cmbLecturer.Items.Clear();
            String sql = "SELECT * FROM Lec_details";
            con.Open();
            cmd = new SqlCommand(sql, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                cmbLecturer.Items.Add(rd["Lecturer_Name"].ToString());


            }
            con.Close();


        }

        private void cmbSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_Records", con);
            Console.WriteLine(adapt);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        /* Making the connection with the SQL server*/

       


     

        public static DataTable DataSource { get; private set; }
        public static string ValueMember { get; private set; }
        public static string DisplayMember { get; private set; }


        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            
        }
    }
}
