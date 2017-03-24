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

        public string DateToP { get => "Дата с: " + this.dateTimePicker1.Value.ToString("dd.MM.yyyy"); }
        public string DateToF { get => "Дата по: " + this.dateTimePicker2.Value.ToString("dd.MM.yyyy"); }

        public event EventHandler<string> OnDateToClick1;
        public event EventHandler<string> OnDateToClick2;

        public void OkButton_Click(object sender, EventArgs e)
        {
      
             Close();

        }
    }
}
