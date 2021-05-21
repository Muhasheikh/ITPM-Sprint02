using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentsAndTagsManagement.Forms
{
    public partial class FormDashboard : Form
    {

        /* Making the connection with the SQL server*/


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EIA1KI\SQLEXPRESS;Initial Catalog=TimeTableManagement;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        private SqlCommand command1;

        public FormDashboard()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            LoadData2();



        }

        //load data

        private void LoadData2()
        {

            try
            {

                String getLecturers = "select count(*) from Subject_Management";



                con.Open();




                command1 = new SqlCommand(getLecturers, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    lableSub.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void LoadData1()
        {

            try
            {

                String getLecturers = "select count(*) from Lec_Details";



                con.Open();




                command1 = new SqlCommand(getLecturers, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    labelLecs.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        private void LoadData()
        {
            try
            {

                String getStudents = "select count(*) from Student_Management";



                con.Open();




                command1 = new SqlCommand(getStudents, con);


                SqlDataReader reader1 = command1.ExecuteReader();


                while (reader1.Read())
                {
                    int studentCount = reader1.GetInt32(0);
                    lableSt.Text = studentCount.ToString();


                    con.Close();
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        private void labelTTG_Click(object sender, EventArgs e)
        {

        }
    }
}
