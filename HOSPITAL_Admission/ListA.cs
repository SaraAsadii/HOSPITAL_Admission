using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_Admission
{
    public partial class ListA : Form
    {
        public ListA()
        {
            InitializeComponent();
        }

        private void ListA_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query2 = " SELECT Ae FROM Ae ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string ae = reader2["Ae"].ToString();
                comboBox2.Items.Add(ae);
                comboBox3.Items.Add(ae);
                comboBox4.Items.Add(ae);
            }
            reader2.Close();


            string query3 = " SELECT Insurance FROM Insurance ";
            SqlCommand cmd3 = new SqlCommand(query3, sc);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string insurance = reader3["Insurance"].ToString();
                comboBox1.Items.Add(insurance);
            }
            reader3.Close();
            sc.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox6.Text;
                string patient = textBox1.Text;
                string insurance = comboBox1.Text;
                string diagnosis = textBox7.Text;
                string ae1 = comboBox2.Text;
                string ae2 = comboBox3.Text;
                string ae3 = comboBox4.Text;
                string p1 = textBox2.Text;
                string p2 = textBox3.Text;
                string p3 = textBox4.Text;
                string total = textBox5.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO ListA(AdmissionID,Patient,Insurance,Diagnosis,Ae1,Ae2,Ae3,P1,P2,P3,Total) VALUES ('" + madmissionid + "' , N'" + patient + "' , N'" + insurance + "' , N'" + diagnosis + "' , N'" + ae1 + "' , N'" + ae2 + "' , N'" + ae3 + "' , '" + p1 + "' , '" + p2 + "' , '" + p3 + "' , '" + total + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox6.Text);
                cmd.Parameters.AddWithValue("patient", textBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox1.Text);
                cmd.Parameters.AddWithValue("diagnosis", textBox7.Text);
                cmd.Parameters.AddWithValue("ae1", comboBox2.Text);
                cmd.Parameters.AddWithValue("ae2", comboBox3.Text);
                cmd.Parameters.AddWithValue("ae3", comboBox4.Text);
                cmd.Parameters.AddWithValue("p1", textBox2.Text);
                cmd.Parameters.AddWithValue("p2", textBox3.Text);
                cmd.Parameters.AddWithValue("p3", textBox4.Text);
                cmd.Parameters.AddWithValue("total", textBox5.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox6.Text;
                string patient = textBox1.Text;
                string insurance = comboBox1.Text;
                string diagnosis = textBox7.Text;
                string ae1 = comboBox2.Text;
                string ae2 = comboBox3.Text;
                string ae3 = comboBox4.Text;
                string p1 = textBox2.Text;
                string p2 = textBox3.Text;
                string p3 = textBox4.Text;
                string total = textBox5.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE ListA SET AdmissionID = '" + madmissionid + "' , Patient = N'" + patient + "' , Insurance = N'" + insurance + "' , Diagnosis = N'" + diagnosis + "' , Ae1 = N'" + ae1 + "' , Ae2 = N'" + ae2 + "' , Ae3 = '" + ae3 + "' , P1 = '" + p1 + "' , P2 = '" + p2 + "' , P3 = '" + p3 + "' , Total = '" + total + "' WHERE AdmissionID = '" + madmissionid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox6.Text);
                cmd.Parameters.AddWithValue("patient", textBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox1.Text);
                cmd.Parameters.AddWithValue("diagnosis", textBox7.Text);
                cmd.Parameters.AddWithValue("ae1", comboBox2.Text);
                cmd.Parameters.AddWithValue("ae2", comboBox3.Text);
                cmd.Parameters.AddWithValue("ae3", comboBox4.Text);
                cmd.Parameters.AddWithValue("p1", textBox2.Text);
                cmd.Parameters.AddWithValue("p2", textBox3.Text);
                cmd.Parameters.AddWithValue("p3", textBox4.Text);
                cmd.Parameters.AddWithValue("total", textBox5.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ویرایش نشدند");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox6.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM ListA WHERE AdmissionID = '" + madmissionid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox6.Text);
                cmd.Parameters.AddWithValue("patient", textBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox1.Text);
                cmd.Parameters.AddWithValue("diagnosis", textBox7.Text);
                cmd.Parameters.AddWithValue("ae1", comboBox2.Text);
                cmd.Parameters.AddWithValue("ae2", comboBox3.Text);
                cmd.Parameters.AddWithValue("ae3", comboBox4.Text);
                cmd.Parameters.AddWithValue("p1", textBox2.Text);
                cmd.Parameters.AddWithValue("p2", textBox3.Text);
                cmd.Parameters.AddWithValue("p3", textBox4.Text);
                cmd.Parameters.AddWithValue("total", textBox5.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات حذف نشدند");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admissin a = new Admissin();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            int c = int.Parse(textBox4.Text);
            int sum = (a + b + c);
            textBox5.Text = sum.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ae = textBox10.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Price FROM Ae WHERE Code = '" + ae + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Price"].ToString();
            }
            reader.Close();

            string ae2 = textBox9.Text;
            string query2 = " SELECT Price FROM Ae WHERE Code = '" + ae2 + "' ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                textBox3.Text = reader2["Price"].ToString();
            }
            reader2.Close();

            string ae3 = textBox8.Text;
            string query3 = " SELECT Price FROM Ae WHERE Code = '" + ae3 + "' ";
            SqlCommand cmd3 = new SqlCommand(query3, sc);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                textBox4.Text = reader3["Price"].ToString();
            }
            reader3.Close();
            sc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox6.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Patient, Insurance, Diagnosis FROM Admission WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["Patient"].ToString();
                comboBox1.Text = reader["Insurance"].ToString();
                textBox7.Text = reader["Diagnosis"].ToString();
            }
            reader.Close();
            sc.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox6.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT * FROM ListA WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["Patient"].ToString();
                comboBox1.Text = reader["Insurance"].ToString();
                textBox7.Text = reader["Diagnosis"].ToString();
                comboBox2.Text = reader["Ae1"].ToString();
                comboBox3.Text = reader["Ae2"].ToString();
                comboBox4.Text = reader["Ae3"].ToString();
                textBox2.Text = reader["P1"].ToString();
                textBox3.Text = reader["P2"].ToString();
                textBox4.Text = reader["P3"].ToString();
                textBox5.Text = reader["Total"].ToString();
            }
            reader.Close();
            sc.Close();
        }
    }
}
