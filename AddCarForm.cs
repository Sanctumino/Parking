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
        public static string ID;
        public AddCarForm()
        {
            InitializeComponent();
            
        }

        //Добавить новую машину 
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

        //Изменить информацию о машине
        private void EditCar()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader EditCarReader;
            try
            {
                SqlCommand EditCarSqlCommand = new SqlCommand();
                SqlDataAdapter EditCarSqlDataAdapter = new SqlDataAdapter();
                EditCarSqlCommand.CommandText = "EditCar";
                EditCarSqlCommand.CommandType = CommandType.StoredProcedure;
                EditCarSqlCommand.Parameters.AddWithValue("@ID",ID);
                EditCarSqlCommand.Parameters.AddWithValue("@Make", MakeTB.Text);
                EditCarSqlCommand.Parameters.AddWithValue("@Model", ModelTB.Text);
                EditCarSqlCommand.Parameters.AddWithValue("@CarNumber", CarNumberTB.Text);
                EditCarSqlCommand.Connection = con;
                con.Open();
                EditCarReader = EditCarSqlCommand.ExecuteReader();
                EditCarSqlDataAdapter.SelectCommand = EditCarSqlCommand;
                EditCarReader.Close();
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
                if (Type == "Add")
                {
                    AddNewCar();
                }
                else
                {
                    EditCar();
                }
            {
                Close();
            }
        }
    }
}
