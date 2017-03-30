using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Task1
{
    public partial class Form1 : Form
    {
        Cities C1 = new Cities();
        Countries C2 = new Countries();
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        string sqlExpression = "SELECT * FROM Countries";
        string sqlExpression1 = "SELECT * FROM Cities WHERE country_id = 1";
        string sqlExpression2 = "SELECT * FROM Cities WHERE country_id = 2";
        string sqlExpression3 = "SELECT * FROM Cities WHERE country_id = 3";

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                object country_id = 0;
                object country_name = 0;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        country_id = reader.GetValue(0);
                        country_name = reader.GetValue(1);
                        comboBox1.Items.Add(country_name);
                        comboBox1.SelectedIndex = 0;
                    }
                }
                reader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    listBox1.Items.Clear();
                    connection1.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection1);
                    object city_id = 0;
                    object city_name = 0;

                    SqlDataReader reader1 = command1.ExecuteReader();

                    if (reader1.HasRows) // если есть данные
                    {
                        while (reader1.Read()) // построчно считываем данные
                        {
                            city_id = reader1.GetValue(1);
                            city_name = reader1.GetValue(2);
                            listBox1.Items.Add(city_name);
                            listBox1.SelectedIndex = 0;
                        }
                    }
                    reader1.Close();
                }
            }
            
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    connection2.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression2, connection2);
                    object city_id = 0;
                    object city_name = 0;

                    SqlDataReader reader2 = command1.ExecuteReader();

                    if (reader2.HasRows) // если есть данные
                    {
                        while (reader2.Read()) // построчно считываем данные
                        {
                            city_id = reader2.GetValue(1);
                            city_name = reader2.GetValue(2);
                            listBox1.Items.Add(city_name);
                            listBox1.SelectedIndex = 0;
                        }
                    }
                    reader2.Close();
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                using (SqlConnection connection3 = new SqlConnection(connectionString))
                {
                    connection3.Open();
                    SqlCommand command1 = new SqlCommand(sqlExpression3, connection3);
                    object city_id = 0;
                    object city_name = 0;

                    SqlDataReader reader3 = command1.ExecuteReader();

                    if (reader3.HasRows) // если есть данные
                    {
                        while (reader3.Read()) // построчно считываем данные
                        {
                            city_id = reader3.GetValue(1);
                            city_name = reader3.GetValue(2);
                            listBox1.Items.Add(city_name);
                            listBox1.SelectedIndex = 0;
                        }
                    }
                    reader3.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
