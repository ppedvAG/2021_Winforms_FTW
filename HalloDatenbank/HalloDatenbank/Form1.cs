using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HalloDatenbank
{
    public partial class Form1 : Form
    {
        BindingList<Employee> employees = new BindingList<Employee>();


        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource1;

            bindingSource1.DataSource = employees;

            vornameTextBox.DataBindings.Add(nameof(TextBox.Text), bindingSource1, nameof(Employee.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox.DataBindings.Add(nameof(TextBox.Text), bindingSource1, nameof(Employee.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
            gebDatumDateTimePicker.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource1, nameof(Employee.BirthDate), true, DataSourceUpdateMode.OnPropertyChanged);


            textBox3.DataBindings.Add("Text", textBox4, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("BackColor", textBox4, "Text", true, DataSourceUpdateMode.OnPropertyChanged);


        }

        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=NORTHWND;Trusted_Connection=true");
                con.Open();
                //MessageBox.Show("Verbindung hergestellt");

                SqlCommand countCmd = new SqlCommand();
                countCmd.Connection = con;
                countCmd.CommandText = "SELECT Count(*) FROM Employees";

                object countAlsObj = countCmd.ExecuteScalar();
                if (countAlsObj is int countAlsInt)
                {
                    MessageBox.Show($"{countAlsInt} Employees in DB");
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Employees";

                SqlDataReader reader = cmd.ExecuteReader();

                employees.Clear();
                while (reader.Read())
                {
                    Employee emp = new Employee();

                    emp.Id = reader.GetInt32(0);
                    emp.LastName = reader.GetString(1); //per get mehoden: richtiger Datentyp, aber muss DB-spalteindex kennen

                    object FirstNameAlsObj = reader["FirstName"]; //per DB-Spaltenname, aber muss selbst den typ umwandlung

                    emp.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    emp.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate")); //beste: richtiger typ + per Spaltenname abfragen

                    employees.Add(emp);
                }

                con.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Fehler: {ex.Number} {ex.Message} {ex.ErrorCode} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.GetType()} {ex.Message}");
            }
        }

        private void saveAsXMLButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);

                XmlSerializer serial = new XmlSerializer(typeof(List<Employee>));
                serial.Serialize(writer, employees.ToList());

                writer.Close();
            }
        }

        private void openXMLFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);

                XmlSerializer serial = new XmlSerializer(typeof(List<Employee>));
                List<Employee> emps = (List<Employee>)serial.Deserialize(reader);
                employees.Clear();
                //kurz:
                emps.ForEach(x => employees.Add(x));
                //oder lang:
                //foreach (Employee emp in emps)
                //{
                //    employees.Add(emp);
                //}

                reader.Close();
            }
        }
    }
}
