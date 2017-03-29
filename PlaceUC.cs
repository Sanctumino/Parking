using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ParkingSystem
{
    public partial class PlaceUC : UserControl
    {
        public PlaceUC()
        {
            InitializeComponent();
        }
        
        //Отказ от места
        private void AbandonPlaceButton_Click(object sender, EventArgs e)
        {
            string Message = "Вы действительно хотите отказаться от места?";
            string Caption = "Отказ от места";
            var AbandonResult =  MessageBox.Show(Message,Caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (AbandonResult == DialogResult.Yes)
            {
                string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(ConStr);
                SqlDataReader AbandonPlaceReader;
                try
                {
                    SqlCommand AbandonParkingPlaceSQLCommand = new SqlCommand();
                    SqlDataAdapter CarInfoDataAdapter = new SqlDataAdapter();
                    AbandonParkingPlaceSQLCommand.CommandText = "ReleaseParkingPlace";
                    AbandonParkingPlaceSQLCommand.CommandType = CommandType.StoredProcedure;
                    AbandonParkingPlaceSQLCommand.Parameters.AddWithValue("@PersonID", Authorization.PersonID);
                    AbandonParkingPlaceSQLCommand.Connection = con;
                    con.Open();
                    AbandonPlaceReader = AbandonParkingPlaceSQLCommand.ExecuteReader();
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //Освобождение места
        private void TempReleasePlaceButton_Click(object sender, EventArgs e)
        {
            ChooseLeaveDatesForm ChooseDateForm = new ChooseLeaveDatesForm();

            ChooseDateForm.OnDateToClick1 += (o, date) => this.DateFromLabel.Text = date;
            ChooseDateForm.OnDateToClick2 += (o, date) => this.DateToLabel.Text = date;
            ChooseDateForm.ShowDialog();              
        }

        //Удалить запись о машине
        private void DeleteCar()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader DeleteCarReader;
            try
            {
                SqlCommand DeleteCarSqlCommand = new SqlCommand();
                SqlDataAdapter DeleteCarSqlDataAdapter = new SqlDataAdapter();
                DeleteCarSqlCommand.CommandText = "DeleteCar";
                DeleteCarSqlCommand.CommandType = CommandType.StoredProcedure;
                DeleteCarSqlCommand.Parameters.AddWithValue("@ID", CarDGV.CurrentRow.Cells[0].Value.ToString());
                DeleteCarSqlCommand.Connection = con;
                con.Open();
                DeleteCarReader = DeleteCarSqlCommand.ExecuteReader();
                DeleteCarSqlDataAdapter.SelectCommand = DeleteCarSqlCommand;
                DeleteCarReader.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm AddCarForm = new AddCarForm();
            AddCarForm.Type = "Add";
            AddCarForm.ShowDialog();
        }

        private void EditCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm AddCarForm = new AddCarForm();
            AddCarForm.Type = "Edit";
            AddCarForm.Text = "Редактировать запись";
            AddCarForm.ID = CarDGV.CurrentRow.Cells[0].Value.ToString();
            AddCarForm.MakeTB.Text = CarDGV.CurrentRow.Cells[1].Value.ToString();
            AddCarForm.ModelTB.Text = CarDGV.CurrentRow.Cells[2].Value.ToString();
            AddCarForm.CarNumberTB.Text = CarDGV.CurrentRow.Cells[3].Value.ToString();
            AddCarForm.ShowDialog();
        }

        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            string Message = "Вы действительно хотите удалить запись?";
            string Caption = "Отказ от места";
            var AbandonResult = MessageBox.Show(Message, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AbandonResult == DialogResult.Yes)
            {
                DeleteCar();
            }
        }
    }
}
