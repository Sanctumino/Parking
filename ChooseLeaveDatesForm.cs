using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class ChooseLeaveDatesForm : Form
    {
        public ChooseLeaveDatesForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = dateTimePicker1.Value;
            DateTime DateTo = dateTimePicker1.Value;
            PlaceUC PlaceUC = new PlaceUC();
            PlaceUC.DateFromLabel.Text = "+DateFrom.ToShortDateString()+";
            PlaceUC.DateToLabel.Text = DateTo.ToShortDateString();
            this.Close();
        }
    }
}
