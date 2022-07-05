using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.ADO.Day14.Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingConn"].ConnectionString);


            cmd = new SqlCommand("Select Stud_Code, Stud_Name, Dept_Code, Stud_Dob, Address from Student_master", con);

            //Open the connection
            con.Open();

            //Execute the command and fetch datas
            reader = cmd.ExecuteReader();

            //Read the first row
            reader.Read();

            //Store into releavant TextBoxes
            TxtStudCode.Text = reader["Stud_Code"].ToString();
            TxtStudName.Text = reader["Stud_Name"].ToString();
            TxtDeptCode.Text = reader["Dept_Code"].ToString();
            DTPStudDob.Text = reader["Stud_Dob"].ToString();
            TxtDeptCode.Text = reader["Address"].ToString();

            //Close the reader object
            reader.Close();

            //Dispose Command Object
            cmd.Dispose();

            //Close the connection
            con.Close();
        }

        public void ClearText()
        {
            TxtStudCode.Text = "";
            TxtStudName.Clear();
            TxtDeptCode.Text = "";
            DTPStudDob.Text = "";
            TxtStudCode.Focus();
            TxtAddress.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("Select Stud_Code, Stud_Name, Dept_Code, Stud_Dob, Address from Student_master Where Stud_Code=@StudCode", con))
                {
                    cmd.Parameters.AddWithValue("@StudCode", TxtStudCode.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            TxtStudName.Text = reader["Stud_Name"].ToString();
                            TxtDeptCode.Text = reader["Dept_Code"].ToString();
                            DTPStudDob.Text = reader["Stud_Dob"].ToString();
                            TxtAddress.Text = reader["Address"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No Record");
                            this.ClearText();
                        }
                    }
                }
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddNewStudent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudCode", TxtStudCode.Text);
                    cmd.Parameters.AddWithValue("@StudName", TxtStudName.Text);
                    cmd.Parameters.AddWithValue("@DeptCode", TxtDeptCode.Text);
                    cmd.Parameters.AddWithValue("@StudDob", DTPStudDob.Text);
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);


                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("New Student Created");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_UpdateAddressAndDobByCode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudDob", DTPStudDob.Text);
                    cmd.Parameters.AddWithValue("@StudCode", TxtStudCode.Text);
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record updated successfully");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_DeleteStudent_master", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudCode", TxtStudCode.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record deleted successfully");
        }
    }
}
