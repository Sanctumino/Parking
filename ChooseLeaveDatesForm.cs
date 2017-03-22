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
        }
        
       /* public string*/
        private void OkButton_Click(object sender, EventArgs e)
        {
string DateFrom = dateTimePicker1.Value.ToString();
           /* DateTime DateTo = dateTimePicker1.Value;
            Program.DateLeaveFrom = DateFrom.ToString();
            Program.DateLeaveTo = DateTo.ToString();*/
            PlaceUC PlaceUC = new PlaceUC();
            PlaceUC.DateFromLabel.Text = DateFrom;

            // PlaceUC.Refresh();
             //CancelButton.Text = DateFrom.ToString();
             Close();

        }
    }
}
