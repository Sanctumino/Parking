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
    public partial class ChooseLeaveDatesForm : Form
    {
        public ChooseLeaveDatesForm()
        {
            InitializeComponent();
            this.OkButton.Click += (o, e) => OnDateToClick1.Invoke(o, DateToP);
            this.OkButton.Click += (o, e) => OnDateToClick2.Invoke(o, DateToF);
            this.OkButton.Click += OkButton_Click;           
        }

        private void FreeParkingPlace()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader FreeParkingPlaceReader;
            try
            {
                SqlCommand FreeParkingPlaceSQLCommand = new SqlCommand();
                SqlDataAdapter FreeParkingPlaceSQLAdapter = new SqlDataAdapter();
                FreeParkingPlaceSQLCommand.CommandText = "FreeParkingPlace";
                FreeParkingPlaceSQLCommand.CommandType = CommandType.StoredProcedure;
                FreeParkingPlaceSQLCommand.Parameters.AddWithValue("@PersonID", Authorization.PersonID);
                FreeParkingPlaceSQLCommand.Parameters.AddWithValue("@DateFrom", dateTimePicker1.Value);
                FreeParkingPlaceSQLCommand.Parameters.AddWithValue("@DateTo", dateTimePicker2.Value);
                FreeParkingPlaceSQLCommand.Connection = con;
                con.Open();
                FreeParkingPlaceReader = FreeParkingPlaceSQLCommand.ExecuteReader();
                FreeParkingPlaceSQLAdapter.SelectCommand = FreeParkingPlaceSQLCommand;
                FreeParkingPlaceReader.Close();

            }
            finally
            {
                con.Close();
            }
        }

        public string DateToP { get => "Дата с: " + this.dateTimePicker1.Value.ToString("dd.MM.yyyy"); }
        public string DateToF { get => "Дата по: " + this.dateTimePicker2.Value.ToString("dd.MM.yyyy"); }

        public event EventHandler<string> OnDateToClick1;
        public event EventHandler<string> OnDateToClick2;

        public void OkButton_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ошибка!");
            }
            else
            { 
                Close();
            }
        }
    }
}
