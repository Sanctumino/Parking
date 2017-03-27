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

namespace ParkingSystem
{
    public partial class AddCarForm : Form
    {
        public static string Type;
        public AddCarForm()
        {
            InitializeComponent();
            
        }

        private void AddNewCar()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader AddCarReader;
            try
            {
                SqlCommand AddCarSqlCommand = new SqlCommand();
                SqlDataAdapter AddCarSqlDataAdapter = new SqlDataAdapter();
                AddCarSqlCommand.CommandText = "AddNewCar";
                AddCarSqlCommand.CommandType = CommandType.StoredProcedure;
                AddCarSqlCommand.Parameters.AddWithValue("@PersonID", Authorization.PersonID);
                AddCarSqlCommand.Parameters.AddWithValue("@Make", MakeTB.Text);
                AddCarSqlCommand.Parameters.AddWithValue("@Model", ModelTB.Text);
                AddCarSqlCommand.Parameters.AddWithValue("@CarNumber", CarNumberTB.Text);
                AddCarSqlCommand.Connection = con;
                con.Open();
                AddCarReader = AddCarSqlCommand.ExecuteReader();
                AddCarSqlDataAdapter.SelectCommand = AddCarSqlCommand;
                AddCarReader.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void AddCarSaveButton_Click(object sender, EventArgs e)
        {
            if (MakeTB.Text == "" | ModelTB.Text == "" | CarNumberTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                AddNewCar();
                Close();
            }
        }
    }
}
