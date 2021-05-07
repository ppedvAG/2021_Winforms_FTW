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

namespace HalloDatenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string lastName = reader.GetString(1); //per get mehoden: richtiger Datentyp, aber muss DB-spalteindex kennen

                    object FirstNameAlsObj = reader["FirstName"]; //per DB-Spaltenname, aber muss selbst den typ umwandlung

                    DateTime birthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate")); //beste: richtiger typ + per Spaltenname abfragen

                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Fehler: {ex.Number} {ex.Message} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }
    }
}
