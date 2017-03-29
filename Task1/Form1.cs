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

        public Form1()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = "SELECT * FROM Countries";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object country_id = reader.GetValue(0);
                        object country_name = reader.GetValue(1);

                        comboBox1.Items.Add(country_name);
                        comboBox1.SelectedIndex = 0;
                    }
                }

                reader.Close();
            }




            //MessageBox.Show(connectionString);

            //C1.Country = "Ukraine";
            //C1.City.Add("Kiev");
            //C1.City.Add("Odessa");
            //C1.City.Add("Lviv");

            //C2.Country = "England";
            //C2.City.Add("London");
            //C2.City.Add("Manchester");
            //C2.City.Add("Newcastle");

            //C3.Country = "Italy";
            //C3.City.Add("Rome");
            //C3.City.Add("Milan");
            //C3.City.Add("Venice");

            //comboBox1.Items.Add(C1);
            //comboBox1.Items.Add(C2);
            //comboBox1.Items.Add(C3);
            //comboBox1.SelectedIndex = 0;

            //comboBox1.ValueMember = "C1.Country";
            //comboBox1.DisplayMember = "C1.Country";

            //comboBox1.ValueMember = "C1.City";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox1.SelectedItems.Range  // доделать + население (memory чето-там), основан (textBox), описание (textBox multiline) + save + load (сериализация)
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
