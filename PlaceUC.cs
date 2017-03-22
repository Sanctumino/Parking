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
            ChooseDateForm.ShowDialog();
        }

       // public string DateF { set DateFromLabel.Text = value; }
    }
}
