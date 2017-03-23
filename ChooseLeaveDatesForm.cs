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
            this.OkButton.Click += (o, e) => OnDateToClick.Invoke(o, DateToP);
            this.OkButton.Click += (o, e) => OnDateToClick.Invoke(o, DateToF);
            this.OkButton.Click += OkButton_Click;
        }

        public string DateToP { get => this.dateTimePicker1.Value.ToString(); }
        public string DateToF { get => this.dateTimePicker2.Value.ToString(); }

        public event EventHandler<string> OnDateToClick;

        public void OkButton_Click(object sender, EventArgs e)
        {
      
             Close();

        }
    }
}
