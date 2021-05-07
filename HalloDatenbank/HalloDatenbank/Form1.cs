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

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Count(*) FROM Employees";

                object countAlsObj = cmd.ExecuteScalar();
                if (countAlsObj is int countAlsInt)
                {
                    MessageBox.Show($"{countAlsInt} Employees in DB");
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
